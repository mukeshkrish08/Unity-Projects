using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
 
    public float moveSpeed = 10;
    public float deadZone = -55;

    void Start()
    {   
        
    }

   
    void Update()
    {
        //transform.position,accessing the position property of the Transform component attached to the GameObject
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
