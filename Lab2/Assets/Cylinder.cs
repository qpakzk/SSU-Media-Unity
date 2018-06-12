using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float yRotation = transform.localEulerAngles.y;
        float zRotation = transform.localEulerAngles.z;

        yRotation += Input.GetAxis("Horizontal");
        zRotation += Input.GetAxis("Vertical");

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, yRotation, zRotation);
    }
}
