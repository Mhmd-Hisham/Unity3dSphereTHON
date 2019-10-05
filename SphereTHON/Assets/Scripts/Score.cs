using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{   
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
       
       if (FindObjectOfType<GameManager>().gameHasEnded == true) {
            scoreText.text = "GAME OVER";
        }
        
        else { 
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
