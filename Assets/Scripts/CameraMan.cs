using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 temp = Camera.main.transform.position;
        temp.y += 1;
        Camera.main.transform.position = temp;

    }
}
