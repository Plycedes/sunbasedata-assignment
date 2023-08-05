using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.IO;



public static class APIhelper 
{
    public static ClientDB GetNewClientDB()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://qa2.sunbasedata.com/sunbase/portal/api/assignment.jsp?cmd=client_data");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();        
        reader.Close();        
        return JsonUtility.FromJson<ClientDB>(json);
    }
}
