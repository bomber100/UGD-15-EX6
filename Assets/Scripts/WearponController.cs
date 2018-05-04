using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearponController : MonoBehaviour {
    public GameObject bulletPref;
    public Transform BulletSpawn;
    public float BulletSpeed = 6.0f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Fire();
        }
    }
    void Fire() {
        var bullet = (GameObject)Instantiate(bulletPref, BulletSpawn.position, BulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * BulletSpeed;
        Destroy(bullet, 2.0f);
    }
}
