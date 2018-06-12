using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public float moveSpeed = 1.0f;
    GameObject ground;
	// Use this for initialization
	void Start () {
        ground = GameObject.Find("Ground");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        else if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        
        if (transform.position.x < ground.transform.position.x &&
           transform.position.z < ground.transform.position.z)
            ground.GetComponent<Renderer>().material.color = Color.red;
        else if (transform.position.x < ground.transform.position.x &&
           transform.position.z > ground.transform.position.z)
            ground.GetComponent<Renderer>().material.color = Color.black;
        else if (transform.position.x > ground.transform.position.x &&
           transform.position.z > ground.transform.position.z)
            ground.GetComponent<Renderer>().material.color = Color.blue;
        else if (transform.position.x > ground.transform.position.x &&
           transform.position.z < ground.transform.position.z)
            ground.GetComponent<Renderer>().material.color = Color.yellow;
            
        

	}
}
