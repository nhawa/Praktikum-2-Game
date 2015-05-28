using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public GameObject gameover;

	public Vector2 velocityUp = new Vector2(0,-2);
	public Vector2 velocityDown = new Vector2(0,2);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			rigidbody.velocity = velocityUp;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rigidbody.velocity = velocityDown;
		}	
	}

	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.tag == "Respawn") {
			GameObject offer = Instantiate(gameover) as GameObject;
			generate.stop = true;
		}
	}
}
