using UnityEngine;
using System.Collections;

public class hancur : MonoBehaviour {
	public GameObject hancurmeteor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.tag == "Respawn") {
			Destroy(obj.gameObject);
		}
	}
}
