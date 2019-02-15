using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelStation : MonoBehaviour {
    [SerializeField] GameObject Player;
    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Player")
        {
            var fuel = collider.gameObject.GetComponent<PlayerScript>().fuelCapacity;
            fuel = fuel + 1;
            collider.gameObject.GetComponent<PlayerScript>().fuelCapacity = fuel;
        }else if(collider.gameObject.name == "PlayerLaser")
        {
            int playerScore = collider.gameObject.GetComponent<PlayerScript>().score;
            playerScore = playerScore + 100;
            collider.gameObject.GetComponent<PlayerScript>().score = playerScore;
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        //Sürekli fueli arttırıyor. Fueli düzenli bir şekilde arttırmanın yolunu bul
    }

}
