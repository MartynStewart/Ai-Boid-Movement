using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderFlip : MonoBehaviour
{
    public bool isVerticleCollider = false;
    public bool isHorizontalCollider = false;

    private Vector3 vFlip = new Vector3(1, 1, -1);
    private Vector3 hFlip = new Vector3(-1, 1, 1);

    void Start() {
        if (isVerticleCollider && isHorizontalCollider) Debug.LogWarning("Incorrect collider settings on me", this.gameObject);
    }


    private void OnTriggerEnter(Collider other) {

        Debug.Log("Triggered");

        if (isVerticleCollider) {
            other.transform.position = Vector3.Scale(other.transform.position, vFlip);
        }

        if (isHorizontalCollider) {
            other.transform.position = Vector3.Scale(other.transform.position, hFlip);
        }
    }
}
