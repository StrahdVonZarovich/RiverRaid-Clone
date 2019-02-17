using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetTrigger : MonoBehaviour {
    [SerializeField] GameObject Jet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Jet.gameObject.GetComponent<Jet>().JetTrigger();
    }
}
