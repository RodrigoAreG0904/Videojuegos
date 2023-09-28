using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObjects : MonoBehaviour{
    
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Obstacle" || other.gameObject.tag == "Soul"){
            Destroy(other.gameObject);
        }
    }
}
