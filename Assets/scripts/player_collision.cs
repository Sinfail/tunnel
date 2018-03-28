
using UnityEngine;

public class player_collision : MonoBehaviour {

    public player_move movement; //adds a box in unity that we can drag a script into (in this case player_move

     void OnCollisionEnter(Collision collisionInfo)//on collision with another object (collisioninfo gives us info about said collision
    {
        Debug.Log(collisionInfo.collider.name);//log what player object has collided with

        if (collisionInfo.collider.tag == "opsticle") //what to do if i colide with opsticle_1
        {
            Debug.Log("WE HIT AN OPSTICLE");
            movement.enabled = false; // disables player movement (player movement code in the player_move script
            // another way to do the above line is  "GetComponent<player_move>().enabled = false;" as the player movement script is called player_move
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
