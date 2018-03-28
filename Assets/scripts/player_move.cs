using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

    public Rigidbody rb; //This is the rigidbody of the "player" cube

    bool space;
    public float forwardForce = 2000f;
    public float backwardsForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpforce = 500f;
	// Use this for initialization
	void Start ()
    {
       // rb.AddForce(0, 200, 500);



	}
     void Update()
    {
        if (Input.GetKey("space"))
        {
            space = true;
        }
        else
        {
            space = false;
        }
    }
    // Update is called once per frame
    //"fixed"Update makes unity likes physics better or some shite
    void FixedUpdate ()
    {
        // add a forward force
       // if (Input.GetKey("w"))
       // {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            //forward
      //  }

        if (Input.GetKey("a"))
        {
            //left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //only executed if condition is met
        }
       // if (Input.GetKey("s"))
      //  {
       //     rb.AddForce(0, 0, -backwardsForce * Time.deltaTime, ForceMode.VelocityChange);
       //     //back
       // }
        if (Input.GetKey("d"))
        {
            //right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //only executed if condition is met
        }

       
        if (space == true)
        {
            //up (done like those beacuase of framerate which means unless bool is constantly checked the game might miss me pressing space because of frame count bs (encountered this a few times in gta)
            rb.AddForce(0, jumpforce * Time.deltaTime, 0);
            //only executed if condition is met
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
