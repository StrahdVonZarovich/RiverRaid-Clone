using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollision : MonoBehaviour {
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Audio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
            Audio.gameObject.GetComponent<AudioManager>().ExpolisionEventController();
        }
        else if(collision.gameObject.name == "PlayerLaser(Clone)")
        {
            var playerScore = Player.gameObject.GetComponent<PlayerScript>().score;
            playerScore = playerScore + 1;
            Player.gameObject.GetComponent<PlayerScript>().score = playerScore;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Audio.gameObject.GetComponent<AudioManager>().MissleExplosionEventController();
        }
    }
}
