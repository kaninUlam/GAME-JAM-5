using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Queue<string> dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = new Queue<string>();
    }
}
