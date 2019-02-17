using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTheme : MonoBehaviour {
    public AudioSource themeSource;
    public AudioClip themeMusic;
	// Use this for initialization
	void Start () {
        themeSource.clip = themeMusic;
        themeSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
