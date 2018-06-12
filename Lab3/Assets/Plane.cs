using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
    public int colCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        colCount++;
        if (colCount % 2 == 0)
            GetComponent<Renderer>().material.color = Color.magenta;
        else
            GetComponent<Renderer>().material.color = Color.grey;
    }
}
