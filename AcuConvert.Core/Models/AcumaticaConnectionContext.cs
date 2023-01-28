#region #Copyright

//  ----------------------------------------------------------------------------------
//   COPYRIGHT (c) 2023 CONTOU CONSULTING
//   ALL RIGHTS RESERVED
//   AUTHOR: Kyle Vanderstoep
//   CREATED DATE: 2023/01/28
// ----------------------------------------------------------------------------------

#endregion

namespace AcuConvert.Core.Models
{
    public class AcumaticaConnectionContext
    {
        public AcumaticaConnectionContext(string endpointName, 
                                          string endpointVersion, 
                                          string resource,
                                          string objectName,
                                          string baseUrl, 
                                          string username,
                                          string password,     
                                          string company)
        {
            if (string.IsNullOrWhiteSpace(endpointName)) throw new ArgumentNullException(nameof(endpointName));
            if (string.IsNullOrWhiteSpace(endpointVersion)) throw new ArgumentNullException(nameof(endpointVersion));
            if (string.IsNullOrWhiteSpace(resource)) throw new ArgumentNullException(nameof(resource));
            if (string.IsNullOrWhiteSpace(objectName)) throw new ArgumentNullException(nameof(objectName));
            if (string.IsNullOrWhiteSpace(baseUrl)) throw new ArgumentNullException(nameof(baseUrl));
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentNullException(nameof(username));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentNullException(nameof(password));

            EndpointName    = endpointName;
            EndpointVersion = endpointVersion;
            Resource        = resource;
            ObjectName = objectName;
            BaseURL         = baseUrl;
            Username        = username;
            Password        = password;
            Company         = company;
        }

        public string EndpointName    { get; }
        public string EndpointVersion { get; }
        public string Resource        { get; }
        public string ObjectName      { get; }
        public string BaseURL         { get; }
        public string Username        { get; }
        public string Password        { get; }
        public string Company         { get; }
    }
}