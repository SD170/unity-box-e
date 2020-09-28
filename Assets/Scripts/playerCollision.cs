using UnityEngine;


public class playerCollision : MonoBehaviour
{   
    public PlayerMovement movement;

    public AudioSource fartSource;


    // public GameManager gameManager;
    // we could've done this but if we want the player to die and then span..
    // as the game manager is not on the same obj....the reference would be empty
    // so instade we'll search for the script game manager

    void OnCollisionEnter(Collision collisionInfo) {
        
        if(collisionInfo.collider.tag == "Obstacle"){
    
            // Debug.Log(collisionInfo.collider.name);
            // older:
            //movement.enabled = false;
            fartSource.Play();
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().GameOver();


        }


    
    }
}
