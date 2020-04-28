using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorFunction : MonoBehaviour
{
    public float speed = 2f;

    void Start() {

    }


    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
