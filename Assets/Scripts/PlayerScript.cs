using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour{

    public float speed, rotationSpeed;
    public Text loserText;
    private float vm,hm;
    private Vector3 carritoRotation;
    private int pointValue = 1;
    private Animator anim;

    void Start(){
        speed = 20.0f;
        //rotationSpeed = 135.0f;
        anim = GetComponent<Animator>();
        if (anim != null){
            anim.Play("Base Layer.Running", 0, 0.25f);
        }
    }

    // Update is called once per frame
    void Update(){
        vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");

        this.transform.Translate(Time.deltaTime*speed*hm,0,0);
        //this.transform.Rotate(Vector3.up,rotationSpeed*Time.deltaTime*hm);

        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Soul")){
            GameManager.Instance.AddPoints(pointValue);
            Destroy(other.gameObject);
        } else if (other.CompareTag("Obstacle")){
            GameManager.Instance.YouLose();
            this.speed = 0;
            this.transform.Translate(0,12,0);
            anim.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision other){
        this.speed = 5.0f;
    }

    private void OnCollisionExit(Collision other){
        this.speed = 20.0f;
    }
}
