using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    public float enemyHealth = 50.0f;
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
            print("A");
        }
        if (agent.transform.position.x == pointB.position.x && agent.transform.position.z == pointB.position.z) {
            agent.SetDestination(pointA.position);
            print("B");
        }
    }

    public void TakeDamage(float amount) {
        enemyHealth -= amount;
        if (enemyHealth <= 0f) {
            Dead();
        }
    }

    void Dead() {
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerController.health -= 10;
        }
    }
}
