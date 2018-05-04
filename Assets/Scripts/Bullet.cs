using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        
        if (other.CompareTag("Bot")) {
            Bot bot = other.GetComponent<Bot>();
            bot.bothealth -= 20;
            print(other.name + " " + bot.bothealth);
            gameObject.SetActive(false);
        }

    }
}
