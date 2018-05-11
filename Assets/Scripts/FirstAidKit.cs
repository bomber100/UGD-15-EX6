using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAidKit : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if (PlayerController.health <= 70){
                PlayerController.health += 30;
                gameObject.SetActive(false);
            }
            else PlayerController.health = 100;
            
        }
    }
}
