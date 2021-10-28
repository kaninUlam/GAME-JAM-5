using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnItem : MonoBehaviour
{
    characterStat item;
    GameObject player;

    bool InZone = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        item = player.GetComponent<characterStat>();

        InZone = false;
    }
    private void Update()
    {
        if(InZone == true && Input.GetKeyDown(KeyCode.E))
        {
            if(item.hasItem == true)
            {
                Debug.Log("has item");
                item.hasItem = false;
            }
            else
            {
                Debug.Log("no item");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("player in zone");
            InZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("player exited the zone");
            InZone = false;
        }
    }
}
