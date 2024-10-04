using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov2 : MonoBehaviour
{
     public float speed = 6f;         // Velocità del Player
    public float jumpForce = .01f;     // Forza del salto
    public float gravityMultiplier = 2f; // Moltiplicatore della gravità

    private Rigidbody rb;
    private bool isGrounded;

    // Controllo per sapere se è a terra
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public int layerToInclude;
    public int layerMask;
    

    void Start()
    {
         layerToInclude = LayerMask.NameToLayer("Ground");

         layerMask = 1 << layerToInclude;
         
        // Prendiamo il Rigidbody dal Player
        groundCheck = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Evitiamo la rotazione del Player causata da collisioni
    }

    void Update()
    {
        // Controlliamo se il Player è a terra
        isGrounded  = Physics.Raycast(groundCheck.position, Vector3.down, 1f, layerMask);

        // Movimento orizzontale
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // Aggiungiamo il movimento alla velocità
        rb.velocity = new Vector3(move.x * speed, rb.velocity.y, move.z * speed);

        // Salto
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        // Aggiunge gravità extra per rendere il salto più realistico
        if (!isGrounded)
        {
            rb.AddForce(Vector3.down * gravityMultiplier, ForceMode.Acceleration);
        }
    }
}
