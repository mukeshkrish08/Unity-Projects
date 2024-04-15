using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrenght = 40;
    public logicScript logic;
    public bool birdIsAlive = true;

    void Start() 
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) 
        {
            myRigidbody2D.velocity = Vector2.up * flapStrenght;
        }
          
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
