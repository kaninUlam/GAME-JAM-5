using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStat : MonoBehaviour
{
    int jumpNum = 1;

    public float speed = 10;
    public float jumpHeight = 10;

    public bool hasItem = false;
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

        if (Input.GetKeyDown("space") && jumpNum >= 1)
        {
            Debug.Log("Jumped");
            rb.AddForce(Vector3.up * jumpHeight,ForceMode.Impulse);
            jumpNum--;
        }
    }
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
