using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public int xDir;
    public int yDir;
    public int zDir;
	// Use this for initialization
	void Start () {
        xDir = 1;
        yDir = 0;
        zDir = 1;
        GetComponent<Transform>().position = new Vector3(2.5f, 0, 2.5f);
	}

    // Update is called once per frame
    void Update () {
        if (GetComponent<Transform>().position.x > 4.0f)
            xDir = -1;
        else if (GetComponent<Transform>().position.x < -4.0f)
            xDir = 1;

        if (GetComponent<Transform>().position.z > 4.0f)
            zDir = -1;
        else if (GetComponent<Transform>().position.z < -4.0f)
            zDir = 1;
        GetComponent<Transform>().position += new Vector3(0.1f * xDir, 0.1f * yDir, 0.1f * zDir);
	}
}
