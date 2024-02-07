using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public GameObject cube;
    void OnTriggerEnter(Collider col) {
        if(col.CompareTag("Player")) {
            Destroy(cube);
        }
    }
}