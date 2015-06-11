using UnityEngine;
using System.Collections;

public class position : MonoBehaviour {
	public Vector2 velocity = new Vector2(-4,-2);
	// Use this for initialization

	void Start () {
		rigidbody.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
		if (generate.stop==true)
			rigidbody.velocity = new Vector2(0,0);
	}

}
