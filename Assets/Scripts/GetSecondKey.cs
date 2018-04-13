using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSecondKey : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //print(PlayerController.havekey);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController.havekey2 = true;
            gameObject.SetActive(false);
            print("key2 picked");
        }
    }
}
