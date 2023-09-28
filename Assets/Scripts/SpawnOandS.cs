using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOandS : MonoBehaviour{

    public GameObject[] spawns = new GameObject[3];
    public GameObject[] obstacleOrSoul = new GameObject[4];

    int s, o;

    void Start(){
        for (int i=0; i<3; i++){
            s = Random.Range(0,3);
            o = Random.Range(0,5);
            Instantiate(obstacleOrSoul[o], spawns[s].transform.position, spawns[s].transform.rotation);
        }
    }
}
