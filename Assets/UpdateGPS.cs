using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPS : MonoBehaviour
{
    public Text coordinates;

    // Update is called once per frame
    private void Update()
    {
        coordinates.text = "Lat:" + GPS.Instance.latitude.ToString() + "\n Long:" + GPS.Instance.longitude.ToString(); 
    }
}
