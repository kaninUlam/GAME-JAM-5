using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStat : MonoBehaviour
{
    public int jumpNum = 1;
    public bool hasItem = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            jumpNum = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            Debug.Log("pickup");
            hasItem = true;
        }
    }
}
