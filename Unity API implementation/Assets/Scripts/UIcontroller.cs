using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{    
    ClientDB clientDB = APIhelper.GetNewClientDB();

    public Text label;
    public Text clientLabel;
    public Text points;

    void Start()
    {
        label.text = clientDB.label;
        clientLabel.text = clientDB.clientsList.clients[0].label;
        points.text = clientDB.data.client1data.address;
    }
   
}
