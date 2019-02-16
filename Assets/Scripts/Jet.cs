using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour {
    bool isJetTriggered = false;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		if(isJetTriggered == true)
        {
            JetMovement();
        }
    }

    public void JetMovement()
    {
        var deltaX = 0.1f;
        var newXPosition = transform.position.x - deltaX;
        var newYPosition = transform.position.y;
        var newZPosition = transform.position.z;
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
    public void JetTrigger()
    {
        isJetTriggered = true;
    }


}
