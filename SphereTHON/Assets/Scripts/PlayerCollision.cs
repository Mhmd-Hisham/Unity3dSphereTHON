using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public bool stopOnCollision = true;
    
    void OnCollisionEnter(Collision collisionInfo){
        if ((collisionInfo.collider.tag == "obstacle") && (stopOnCollision == true)){
            movement.enabled = false;
            
            // Die on Collision
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
