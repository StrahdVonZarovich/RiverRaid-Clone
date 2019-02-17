using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    public AudioSource musicSource;
    public AudioClip explosionClip;
    public AudioClip missleExplosionClip;
    public AudioClip missleFireClip;
    public AudioClip fuelExplosionClip;
    public AudioClip mainThemeClip;
    bool explosionReady = false; // Player to enemy collision
    bool missleExplosion = false; // Enemy to missle collision
    bool missleFire = false;
    bool fuelExplosion = false;
    bool mainTheme = true;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(explosionReady == true)
        {
            musicSource.clip = explosionClip;
            musicSource.Play();
            explosionReady = false;
        }
        if(missleExplosion == true)
        {
            musicSource.clip = missleExplosionClip;
            musicSource.Play();
            missleExplosion = false;
        }
        if(missleFire == true)
        {
            musicSource.clip = missleFireClip;
            musicSource.Play();
            missleFire = false;
        }
        if (fuelExplosion == true)
        {
            musicSource.clip = fuelExplosionClip;
            musicSource.Play();
            fuelExplosion = false;
        }

    }



    public void ExpolisionEventController()
    {
        explosionReady = true;
    }
    public void MissleExplosionEventController()
    {
        missleExplosion = true;
    }
    public void FireMissle()
    {
        missleFire = true;
    }
    public void FuelExplosion()
    {
        fuelExplosion = true;
    }
    public void mainThemeMusic()
    {
        mainTheme = true;
    }

}
