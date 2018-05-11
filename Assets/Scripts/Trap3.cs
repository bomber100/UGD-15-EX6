using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap3 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerController.health -= 35;
            gameObject.SetActive(false);
        }
    }
}
