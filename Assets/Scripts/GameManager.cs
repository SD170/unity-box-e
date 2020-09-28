using UnityEngine;
//for restart,reload or scene change
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    bool gameHasEnded = false;
    float restartDelay = 1f;

    public GameObject levelCompelteUI;


    public void CompleteLevel1(){
        // Debug.Log("level1 complete");
        // levelCompelteUI.SetActive(false);    to disable it
        levelCompelteUI.SetActive(true);
    }

    public void GameOver (){
        //if we fall of the edge...the game over is calling multiple time

        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("GAME OVER !! ");

            //kinda like set timeout
            //first param is the name of the func as a string
            Invoke("Restart", restartDelay);

            //  Restart();
        }
    }

    void Restart(){

        // SceneManager.LoadScene("Level01");
        // its fine but ... sometime we dont want to load the level 1
        // if there is 10 levels...and the player dies in the 8th
        // after the death the 8 level will load again not 1
        // so theres a way to call the CURRENTLY ACTIVE scene
        // remember loadscene takes a string....so (.name)
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
