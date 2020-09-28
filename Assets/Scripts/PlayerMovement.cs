using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float ForwardForce = 2000f; 
    public float SideForce = 500f; 
    public float JumpForceY = 100f; 

    public int jumpCount = 0;

    public bool isPlayerOnGround = true;
    // Start is called before the first frame update
    // void Start()
    // {
    //     rb.AddForce(0,200,500);
    // }

    // Update is called once per frame
    //the name is fixedupdate cuz we're messing with phy
    //in case of force,velocity use fixedupdate
    //itmakes evrything smoother and cooling btr.
    void FixedUpdate()
    {   


        // //stop the cube from rolling
        // transform.rotation = Quaternion.identity;
        //or go to rigidbody ..vonstarins and fix rotation on x axis


        //adding forward force to the player
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);

        if(Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }        
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(-SideForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        //Jump
        if(Input.GetKey(KeyCode.Space) && isPlayerOnGround){
            rb.AddForce(Vector3.up * JumpForceY,ForceMode.Impulse); 
            isPlayerOnGround = false;
        }
        //if the player reaches a postion of -1 in y axis...its game over.

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().GameOver();

        }


    }

    private void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Ground"){
            isPlayerOnGround = true;
        }
    }

}
