using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelStation : MonoBehaviour {
    [SerializeField] GameObject Player;
    private void OnTriggerStay2D(Collider2D collision)
    {
        var colliderName =  collision.gameObject.name;
        if(colliderName == "Player")
        {
            var fuel = collision.gameObject.GetComponent<PlayerScript>().fuelCapacity;
            fuel = fuel + 1;
            collision.gameObject.GetComponent<PlayerScript>().fuelCapacity = fuel;
        }else if (colliderName == "PlayerLaser(Clone)")
        {
            var playerScore = Player.gameObject.GetComponent<PlayerScript>().score;
            playerScore = playerScore + 1;
            Player.gameObject.GetComponent<PlayerScript>().score = playerScore;
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

    }


}
