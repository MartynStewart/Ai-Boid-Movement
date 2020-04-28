using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Bot : MonoBehaviour
{

    NavMeshAgent agent;

    void Start() {
        agent = GetComponentInChildren<NavMeshAgent>();
    }

    //Seek

        //Flee
        //Arrive
        //Pursuit
        //Evade
        //Wander


    void Update() {
        
    }
}
