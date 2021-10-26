using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Name : MonoBehaviour
{

    public Text NameLabel;
    void Update()
    {
        Vector3 wantedpos = Camera.main.WorldToScreenPoint(this.transform.position);
        NameLabel.transform.position = wantedpos;
    }
}
