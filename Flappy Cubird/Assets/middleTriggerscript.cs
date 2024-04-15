using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleTriggerscript : MonoBehaviour
{
    public logicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
        // In Unity, scripts can't always be directly dragged onto GameObjects, especially with dynamically spawned GameObjects or prefabs.
        // This is because such GameObjects don't exist in the scene until runtime. Thus, code based referencing, like using GameObject.FindGameObjectWithTag(),
        // Here,Adding the "Logic" tag to a GameObject helps scripts find it during the game.
        // This makes it possible for one script to talk to another script attached to that GameObject.
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.layer == 3) 
        {
            logic.addScore(1);
        }
    }
}
