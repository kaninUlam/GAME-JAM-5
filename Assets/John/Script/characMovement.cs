using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characMovement : MonoBehaviour
{
    characterStat JumpNum;

    public float jumpHeight = 10;
    public float speed = 10;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        JumpNum = GetComponent<characterStat>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horizontalInput * Time.deltaTime * speed, 0, verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown("space") && JumpNum.jumpNum >= 1)
        {
            Debug.Log("Jumped");
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            JumpNum.jumpNum--;
        }

    }
}
