using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnItem : MonoBehaviour
{
    characterStat item;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Capsule");
        item = player.GetComponent<characterStat>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (item.hasItem == true)
            {
                Debug.Log("you returned item");
                item.hasItem = false;
            }
        }
    }
}
