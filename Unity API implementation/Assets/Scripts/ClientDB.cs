[System.Serializable]
public class ClientDB
{
    public ClientsList clientsList;
    public Data data;
    public string label;
}

[System.Serializable]
public class Client
{
    public bool isManager;
    public int id;
    public string label;
}

[System.Serializable]
public class ClientsList
{
    public Client[] clients;
}

[System.Serializable]
public class Data
{
    public ClientData client1data;
    public ClientData client2data;
    public ClientData client3data;
}

[System.Serializable]
public class ClientData
{
    public string address;
    public string name;
    public int points;
}
