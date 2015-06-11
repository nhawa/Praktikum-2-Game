using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controller : MonoBehaviour {
	public Text Score;

	public GameObject gameover;
	public AudioClip bomb;
	public bool play = true;
	public Vector2 velocityUp = new Vector2(0,-2);
	public Vector2 velocityDown = new Vector2(0,2);
	public Vector2 velocityStop = new Vector2(0,0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (play == true) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				rigidbody.velocity = velocityUp;
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				rigidbody.velocity = velocityDown;
			}	
		}
		else rigidbody.velocity = velocityStop;
	}

	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.tag == "Respawn") {
			GameObject offer = Instantiate(gameover) as GameObject;
			generate.stop = true;
			audio.clip = bomb;
			audio.Play();
			play = false;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag=="lewat"){
			int point = int.Parse(Score.text)+1;
			Score.text=point.ToString();
		}
	}
}
