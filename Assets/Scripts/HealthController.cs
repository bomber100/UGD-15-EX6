using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text Healthtxt;

    void Start()
    {
        Healthtxt.text = PlayerController.health.ToString();
    }


    void Update()
    {
        Healthtxt.text = PlayerController.health.ToString();
        if (PlayerController.health <= 20)
        {
            Healthtxt.color = Color.red;
        }
        else if (PlayerController.health <= 50)
        {
            Healthtxt.color = new Color(1f,0.647f,0f);
        }
        
        else if (PlayerController.health <= 80)
        {
            Healthtxt.color = Color.yellow;
        }
        else Healthtxt.color = Color.green;
    }
}
