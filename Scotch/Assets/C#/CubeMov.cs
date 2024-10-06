using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMov : MonoBehaviour
{
   public Vector3 startPos = new Vector3(0, 0, 0);
    public Vector3 endPos = new Vector3(10, 5, -3);
    public float speed = 5f;
    private bool movingToEnd= true;
    public float danno = 1f;

    void Update()
    {

        if (movingToEnd)
        {

            transform.position = Vector3.MoveTowards (transform.position, endPos, speed* Time.deltaTime); 
        }
        if(Vector3.Distance(transform.position, endPos)< 0.01f)
        {
           Debug.Log(name+": Sono arrivato");
            movingToEnd = false;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)   

    {
    if (other.gameObject.CompareTag("Player"))
        {
           
            Debug.Log("Touching object with Player");
            other.gameObject.GetComponent<PlayerMov2>().doDmg(danno);
        }
    }
}
