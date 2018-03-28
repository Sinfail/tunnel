
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gamemanager; //adds box in unity to draf gamemanager script into to refrence it

     void OnTriggerEnter() //onCollisionEnter will not work if collider is marked as triggred.
    {
        gamemanager.CompleteLevel();
    }
}
