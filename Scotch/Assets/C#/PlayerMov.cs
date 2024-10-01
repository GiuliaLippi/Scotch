using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
 public float horizontalInput;
    public float verticalInput;

    public float speed;
    public float turnSpeed = 10;

    void Start()
    {

    }
    void Update()
    {
        // read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the object 
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        //transform.Translate(-Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime );
    }
}
