using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateEnemyMove : MonoBehaviour{

    public float speed;
    
    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
        if (anim != null){
            anim.Play("Base Layer.Roar", 0, 0.25f);
        }
    }

    void FixedUpdate(){
        this.transform.Translate(Time.deltaTime * speed,0,0);
    }
}
