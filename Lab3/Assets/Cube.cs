using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    public float moveSpeed = 10.0f;
    public float turnSpeed = -50.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = transform.position - collision.transform.position;
        direction = direction.normalized * 2000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        else if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.R))
            GetComponent<Renderer>().material.color = Color.red;

        if (Input.GetKey(KeyCode.G))
            GetComponent<Renderer>().material.color = Color.green;

        if (Input.GetKey(KeyCode.B))
            GetComponent<Renderer>().material.color = Color.blue;

        if (Input.GetKey(KeyCode.W))
            GetComponent<Renderer>().material.color = Color.white;
	}
}
