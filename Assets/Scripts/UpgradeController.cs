using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {
    public static int maxHealth = 100;
    public static bool regenPicked = false;
    public int money = 100;
    public int upgradePrice = 20;

    bool regenerating = false;
    int currentUpgradeLevel = 0;
    int maxUpgradeLevel = 5;

    // Use this for initialization
    void Start() {
        
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.U)) {
            if (money > 0) {
                if (currentUpgradeLevel < maxUpgradeLevel) {
                    maxHealth += 5;
                }
                money -= upgradePrice;
            }
        }
        if (regenPicked == true) {
            if (regenerating == false) {
                StartCoroutine(Regen());
                print("StartCoroutine");
            }
        }
    }


    IEnumerator Regen() {
        for (int i = 0; i < 5; i++) {
            regenerating = true;
            PlayerController.health += 1;
            yield return new WaitForSeconds(1.0f);
        }
        regenerating = false;
        regenPicked = false;
    }
}
