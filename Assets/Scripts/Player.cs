using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] float movementSpeed = 0.5f;
    [SerializeField] float cameraSpeed;
    [SerializeField] GameObject Laser;
    [SerializeField] float missleSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        Fire();

	}

    private void Movement(){
        var deltaX = Input.GetAxis("Horizontal");
        var deltaY = 0.08f;
        var newXPosition = transform.position.x + deltaX * movementSpeed;
        var newYPosition = transform.position.y + deltaY;
        var newZPosition = transform.position.z; //This line because of transform position need vec3.
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }

    private void Fire(){
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject laser = Instantiate(Laser, transform.position, Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, missleSpeed);
             
        }
    }
}
