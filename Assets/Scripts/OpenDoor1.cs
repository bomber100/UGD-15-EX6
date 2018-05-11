using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor1 : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        print("OpenDoor1: " + gameObject.name + " - " + other.name);

        if (other.CompareTag("Player")) {
            PlayerController.touchdoor1 = true;
            print("touch the door 1 ");
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerController.touchdoor1 = false;
        }
    }
}
