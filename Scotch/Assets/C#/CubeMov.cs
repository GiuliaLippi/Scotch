using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMov : MonoBehaviour
{
   public Vector3 startPos = new Vector3(0, 0, 0);
    public Vector3 endPos = new Vector3(10, 5, -3);
    public float speed = 5f;
    private bool movingToEnd= true;

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
}
