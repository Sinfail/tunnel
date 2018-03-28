using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_Player : MonoBehaviour {

    public Transform player; // Transform stores a transform objec thing in unity (the cube named player is a transform)
    public Vector3 offset;  //vector 3 stores 3 numbers, ( 3 floats)      
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //"transform" without capital t is the transform of the current object (in this case the camera)
        transform.position = player.position + offset; 
    }
}
