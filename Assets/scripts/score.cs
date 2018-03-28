
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

    public Transform Player;//transform component is responsible for position rotation and scale/
    public Text Scoretext;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       Scoretext.text = Player.position.z.ToString("0");// log player pos
	}
}
