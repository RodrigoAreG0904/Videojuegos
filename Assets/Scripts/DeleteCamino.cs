using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCamino : MonoBehaviour{

    public GameObject camino;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            Destroy(camino, 1.0f);
        }
    }
}
