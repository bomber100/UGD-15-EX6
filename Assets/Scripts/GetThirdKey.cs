using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetThirdKey : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        print("GetThirdKey: " + gameObject.name + " - " + other.name);

        if (other.CompareTag("Player")) {
            PlayerController.havekey3 = true;
            gameObject.SetActive(false);
            print("key3 picked");
        }
    }
}
