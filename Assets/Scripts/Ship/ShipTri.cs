using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTri : MonoBehaviour {

    [SerializeField] GameObject Ship;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Ship>().ShipCollimating();
    }
}
