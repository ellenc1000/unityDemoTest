using UnityEngine;
using System.Collections;

public class cubemove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Transform from;
	public Transform to;
	public float speed = 0.1f;

	// Update is called once per frame
	void Update () {
		float moveSpeed = speed * Time.deltaTime;
		transform.rotation = Quaternion.Lerp(transform.rotation, to.rotation, moveSpeed);//current pos, end pos, movement
		transform.position = Vector3.Lerp(transform.position, to.position, moveSpeed);
	}
}
