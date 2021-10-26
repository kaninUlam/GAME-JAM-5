using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStat : MonoBehaviour
{
    public float speed = 10;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position +  new Vector3(horizontalInput * Time.deltaTime * speed, 0, verticalInput * Time.deltaTime * speed);
    }
}
