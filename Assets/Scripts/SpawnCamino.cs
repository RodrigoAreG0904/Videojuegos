using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCamino : MonoBehaviour{

    public GameObject camino;
    public Transform spawn;

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Instantiate(camino, spawn.position, spawn.rotation);
        }
    }
}
