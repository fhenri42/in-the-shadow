using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
public float speed = 0.1f;
public GameObject test;

     public float horizontalSpeed = 2.0F;
     public float verticalSpeed = 2.0F;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		print(Input.mousePosition);

		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		 float v = verticalSpeed * Input.GetAxis("Mouse Y");
		 test.transform.Rotate(v, h, 0);
		// test.transform.Rotate( Input.mousePosition* Time.deltaTime * speed);
	}
}
