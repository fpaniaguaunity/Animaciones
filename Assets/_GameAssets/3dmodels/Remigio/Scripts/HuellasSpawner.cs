using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuellasSpawner : MonoBehaviour
{
    public GameObject prefabHuellaIzquierda;
    public GameObject prefabHuellaDerecha;
    public Transform transformSpawnerHuellaIzquierda;
    public Transform transformSpawnerHuellaDerecha;
    public void GenerarHuellaIzquierda(){
        Instantiate(prefabHuellaIzquierda, 
            transformSpawnerHuellaIzquierda.position, 
            transformSpawnerHuellaIzquierda.rotation);
    }
    public void GenerarHuellaDerecha(){
        Instantiate(prefabHuellaDerecha, 
            transformSpawnerHuellaDerecha.position, 
            transformSpawnerHuellaDerecha.rotation);
    }
}
