using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NWoW
{
    /// <summary>
    /// Various utility methods to deal with creating web requests, etc.
    /// </summary>
    internal static class Web
    {
        internal static T GetSerializedJSONObject<T>(string strURL)
        {
            Contract.Requires(!string.IsNullOrEmpty(strURL));

            using (WebClient wcClient = new WebClient())
            {
                string strJSONData = string.Empty;

                try
                {
                    strJSONData = wcClient.DownloadString(strURL);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (!string.IsNullOrEmpty(strJSONData))
                {
                    return JsonConvert.DeserializeObject<T>(strJSONData);
                }
                else
                {
                    throw new InvalidDataException("Could not deserialize object from the requested URL.");
                }
            }
        }
    }
}
