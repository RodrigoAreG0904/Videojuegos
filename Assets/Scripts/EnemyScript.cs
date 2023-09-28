using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour{

    public Transform objetivo; // El objeto al que seguirá
    public float velocidad = 5.0f; // Velocidad de seguimiento

    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
        if (anim != null){
            anim.Play("Base Layer.Running Crawl", 0, 0.25f);
        }
    }

    // Hacer que siga al jugador en la siguiente versión
    void Update(){
        if (objetivo != null){
            // Obtenemos la posición actual del objeto
            Vector3 posicionActual = transform.position;

            // Mantenemos la posición Y y Z del objeto
            posicionActual.y = transform.position.y;
            posicionActual.z = transform.position.z;

            // Calculamos la nueva posición en el eje X
            float nuevaPosicionX = Mathf.MoveTowards(transform.position.x, objetivo.position.x, velocidad * Time.deltaTime);

            // Asignamos la nueva posición al objeto
            transform.position = new Vector3(nuevaPosicionX, posicionActual.y, posicionActual.z);
        }
    }
}
