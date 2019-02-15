using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CameraMovement();
	}

    private void CameraMovement(){
        var deltaY= 0.08f;
        var newXPosition = transform.position.x;
        var newYPosition = transform.position.y + deltaY;  
        var newZPosition = transform.position.z; //This line because of transform position need vec3.
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
}
