using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;

    public void EndGame(){
    
        if (gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            gameHasEnded = true;
        }
    }
    
    public void CompleteLevel1(){
        Debug.Log("You win!");
        completeLevelUI.SetActive(true);
        movement.enabled = false;

    }
    
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }
    
    
    

}
