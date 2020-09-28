using UnityEngine;

public class EndTrigger : MonoBehaviour
{   
    public GameManager gameManager;
    private void OnTriggerEnter(Collider colliderInfo) {

        if(colliderInfo.tag == "Player"){
            gameManager.CompleteLevel1();
        }
       
    }

}
