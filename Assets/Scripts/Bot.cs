﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour {
    public int bothealth = 100;
    public Transform pointA;
    public Transform pointB;
    NavMeshAgent agent;


    void Start() {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = pointA.position;
    }

    void Update() {
        if (agent.transform.position.x == pointA.position.x && agent.transform.position.z == pointA.position.z) {
            agent.SetDestination(pointB.position);
           // print("A"); 
        }
        if (agent.transform.position.x == pointB.position.x && agent.transform.position.z == pointB.position.z) {
            agent.SetDestination(pointA.position);
           // print("b");
        }
        if (bothealth <= 0) {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player")) {
            PlayerController.health -= 10;

        }
    }

}