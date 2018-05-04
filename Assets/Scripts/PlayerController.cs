using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static int health = 100;
    public static bool havekey = false;
    public static bool havekey1 = false;
    public static bool havekey2 = false;
    public static bool havekey3 = false;
    public static bool touchdoor = false;
    public static bool touchdoor1 = false;
    public static bool touchdoor2 = false;
    public static bool touchdoor3 = false;
    public float speed = 10.0f;
    public float gravity = -9.8f;
    public float jumpheight = 3.0f;

    private CharacterController _charCont;

    void Start() {
        _charCont = GetComponent<CharacterController>();
    }

    void Update() {
        if (health > 0) {
            float deltaX = Input.GetAxis("Horizontal") * speed;
            float deltaZ = Input.GetAxis("Vertical") * speed;
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, speed);

            movement.y = gravity;

            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charCont.Move(movement);

            if (Input.GetKeyDown(KeyCode.Space)) {
                Vector3 jump = new Vector3(0, jumpheight, 0);
                jump = Vector3.ClampMagnitude(jump, jumpheight);
                _charCont.Move(jump);
            }
        }
        else {
            print("You died");
        }
    }

    private void OnTriggerEnter(Collider other) {
        //print("PlayerController: " + gameObject.name + " - " + other.name);
        //print("door(" + PlayerController.touchdoor +
        //       ", " + PlayerController.touchdoor1 +
        //       ", " + PlayerController.touchdoor2 +
        //       ", " + PlayerController.touchdoor3 + ") " +
        //       "key(" + PlayerController.havekey +
        //       ", " + PlayerController.havekey1 +
        //       ", " + PlayerController.havekey2 +
        //       ", " + PlayerController.havekey3 + ")"
        //        );

        if ((PlayerController.havekey == true) && (PlayerController.touchdoor == true)) {
            other.gameObject.SetActive(false);
           // print("0");
        }
        else if ((PlayerController.havekey1 == true) && (PlayerController.touchdoor1 == true)) {
            other.gameObject.SetActive(false);
         //   print("1");
        }
        else if ((PlayerController.havekey2 == true) && (PlayerController.touchdoor2 == true)) {
            other.gameObject.SetActive(false);
         //   print("2");
           
        }
        else if ((PlayerController.havekey3 == true) && (PlayerController.touchdoor3 == true)) {
            other.gameObject.SetActive(false);
         //   print("3");
        }
    }
}

