using UnityEngine;
using System.Collections;

public class generate : MonoBehaviour {
	public GameObject meteor;
	public Vector3 pos;
	// Use this for initialization
	public static bool stop;
	void Start () {
		InvokeRepeating ("CreateObstacle", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (stop == true)
			CancelInvoke ("CreateObstacle");
	}

	void CreateObstacle(){
		pos.y = Random.Range (-4, 4);
		Instantiate (meteor, new Vector3 (9, pos.y, -0.5f), Quaternion.identity);
	}
}
