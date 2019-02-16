using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float cameraFlowSpeed;
    [SerializeField] GameObject Laser;
    [SerializeField] public int fuelCapacity;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] public int score = 0;
    [SerializeField] Text scoreText;
    // Use this for initialization
    void Start () {
        InvokeRepeating("FuelDec", 1, 1);
        if (scoreText != null)
        {
            scoreText.text = "Score";
        }
    }

    // Update is called once per frame
    void Update () {
        Movement();
        Fire();
        FuelOut();
        ScoreDisplay();
	}

    void HelloWorld(){
        Debug.Log("Hello World");
    }

    private void Movement()
    {
        var deltaX = Input.GetAxis("Horizontal");
        var deltaY = 0.08f;
        var newXPosition = transform.position.x + deltaX * moveSpeed;
        var newYPosition = transform.position.y + deltaY;
        var newZPosition = transform.position.z; //This line because of transform position need vec3.
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }

    private void Fire(){
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject laser = Instantiate(Laser, transform.position, Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);

        }
    }
    private void FuelDec(){
        fuelCapacity = fuelCapacity - 1;
    }

    private void FuelOut(){
        if(fuelCapacity == 0){
            Destroy(this.gameObject);
        }
    }

    private void ScoreDisplay()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
