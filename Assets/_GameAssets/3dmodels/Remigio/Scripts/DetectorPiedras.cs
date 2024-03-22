using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPiedras : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if (c.gameObject.CompareTag("Piedra")){
            GetComponent<Animator>().SetTrigger("tropezon");
        }
    }
}
