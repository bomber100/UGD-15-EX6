using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        print("OpenDoor0: " + gameObject.name + " - " + other.name);

        if (other.CompareTag("Player")) {
            PlayerController.touchdoor = true;

        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerController.touchdoor = false;
        }
    }
}
