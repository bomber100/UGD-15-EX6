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
    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if (PlayerController.health <= UpgradeController.maxHealth){
                UpgradeController.regenPicked = true;
                gameObject.SetActive(false);
            }
        }
    }
}
