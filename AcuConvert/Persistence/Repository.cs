#region #Copyright
//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------
#endregion

using System.Data.SqlClient;
using AcuConvert.Core.Interfaces;
using AcuConvert.Core.Models;
using AcuConvert.Core.Models.Data;
using AcuConvert.Core.Models.Data.DB;
using Dapper;

namespace AcuConvert.Persistence
{
    public class Repository : ISyncRepository
    {
        private readonly SqlConnection _conn;

        public Repository()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource         = "local";
            builder.IntegratedSecurity = true;
            builder.UserID             = @"TELAVI\KyleVanderstoep";
            
            _conn    = new SqlConnection(builder.ToString());
        }
        
        public IEnumerable<Field>                        GetSourceSchema(string instanceID)
        {
            var fields = _conn.Query<SyncField>($"SELECT * FROM SyncField Where InstanceID = '{instanceID}'");
            foreach (SyncField field in fields)
            {
                yield return new Field(field.SourceFieldName, field.DataType, field.IsKey);
            }
        }

        public IEnumerable<Row>                          GetSyncDataSet(string  instanceID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValuePair<string, string>> GetSourceConnectionSettings()
        {
            var querySettings =
                _conn.Query<ConnectionSetting>($"SELECT * FROM ConnectionSetting Where IsDest = 1");

            return querySettings.Select(i => new KeyValuePair<string, string>(i.SettingID?.Trim(), i.Value?.Trim()));
        }

        public AcumaticaConnectionContext                GetDestConnectionSettings(string instanceId)
        {
            var querySettings =
                _conn.Query<ConnectionSetting>($"SELECT * FROM ConnectionSetting Where IsDest = 1").ToArray();
            var syncInstance =
                GetSyncInstance(instanceId) ?? throw new ArgumentNullException("GetSyncInstance(instanceId)");
            
            return new AcumaticaConnectionContext(
                querySettings.FirstOrDefault(q=>string.Equals(q.SettingID,"AcuUrl"))?.Value,
                querySettings.FirstOrDefault(q=>string.Equals(q.SettingID,"AcuUsername"))?.Value,
                querySettings.FirstOrDefault(q=>string.Equals(q.SettingID,"AcuPassword"))?.Value,
                querySettings.FirstOrDefault(q=>string.Equals(q.SettingID,"AcuCompany"))?.Value,
                syncInstance.AcuEndpointName,
                syncInstance.AcuEndpointVersion,
                syncInstance.AcuResourceName,
                syncInstance.AcuResourceName);
        }

        public IEnumerable<KeyValuePair<string, string>> GetInstanceQuerySettings(string instanceID)
        {
            var querySettings =
                _conn.Query<SourceQuerySetting>($"SELECT * FROM SourceQuerySetting Where InstanceID = '{instanceID}'");

            return querySettings.Select(i => new KeyValuePair<string, string>(i.SettingID?.Trim(), i.Value?.Trim()));
        }

        public SyncInstance? GetSyncInstance(string instanceID)
        {
            var syncInstance =
                _conn.Query<SyncInstance>($"SELECT * FROM SyncInstance Where InstanceID = '{instanceID}'");
            return syncInstance?.FirstOrDefault();
        }

        public AcumaticaConnectionContext GetDestConnectionSettings()
        {
            throw new NotImplementedException();
        }
    }
}