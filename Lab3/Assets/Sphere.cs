using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    public int colCount = 0;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.color = Color.white;
	}

    private void OnCollisionEnter(Collision collision)
    {
        colCount++;
        if (collision.gameObject.name == "Plane")
            GetComponent<Renderer>().material.color = Color.yellow;
        else if (collision.gameObject.name == "Cube")
            GetComponent<Renderer>().material.color = Color.cyan;

        if (collision.gameObject.name == "Plane")
        {
            if (colCount % 2 == 0)
                collision.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            else 
                collision.gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
	}
}
