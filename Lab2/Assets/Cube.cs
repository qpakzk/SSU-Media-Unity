using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    GameObject sphere;
	// Use this for initialization
	void Start () {
        sphere = GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(sphere.transform.position.x, sphere.transform.position.y, sphere.transform.position.z - 3);
	}
}
