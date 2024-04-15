using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 4;
    private float timer = 0;
    public float heightOffset = 5;
    
   
    void Start()
    {
        spawnPipe();
    }

 
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }else
        {   
            spawnPipe();
            timer = 0;
        }
    }   
    void spawnPipe()
    {
        float lowerPoint = transform.position.y - heightOffset;
        float upperPoint = transform.position.y + heightOffset;

        Vector3 newPosition = new Vector3(transform.position.x, Random.Range(lowerPoint, upperPoint), 0);

        Instantiate(pipe, newPosition, transform.rotation);
    }
}
