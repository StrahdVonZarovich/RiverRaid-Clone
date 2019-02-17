using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
    bool isShipDirectionRight = false;
	// Use this for initialization
	void Start () {
        ShipDirectRight();

    }
	
	// Update is called once per frame
	void Update () {
		if(isShipDirectionRight == true)
        {
            ShipDirectLeft();
        }
        else
        {
            ShipDirectRight();
        }
    }

    public void ShipCollimating()
    {
        if(isShipDirectionRight == true)
        {
            isShipDirectionRight = false;
        }
        else
        {
            isShipDirectionRight = true;
        }
    }
    public void ShipDirectLeft()
    {
        var deltaX = 0.08f;
        var newXPosition = transform.position.x - deltaX;
        var newYPosition = transform.position.y;
        var newZPosition = transform.position.z;
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }

    public void ShipDirectRight()
    {
        var deltaX = 0.08f;
        var newXPosition = transform.position.x + deltaX;
        var newYPosition = transform.position.y;
        var newZPosition = transform.position.z;
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
}
