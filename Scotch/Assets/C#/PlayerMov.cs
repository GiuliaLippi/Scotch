using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
 public float horizontalInput;
    public float verticalInput;
    

    public float speed;
    public float jumpStrenght = 10;
    public Rigidbody rb;

    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(Mathf.Approximately(rb.velocity.y,0) && Input.GetButtonDown ("Jump"))
          rb.velocity = new Vector3(rb.velocity.x,jumpStrenght,rb.velocity.z);
        // read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the object 
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
        
    }
}
