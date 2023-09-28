using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour{

    public float currentSpeed; // Velocidad actual para ver que si cambie como quiero
    public GameManager gameManager;

    private void Start(){
        gameManager = FindFirstObjectByType<GameManager>();

        if (gameManager != null){
            currentSpeed = gameManager.currentSpeed; // Configura la velocidad inicial
        }else{
            Debug.LogWarning("No se encontró el GameManager en la escena.");
        }
    }
    

    public float speed;
    // Update is called once per frame
    void FixedUpdate(){
        currentSpeed += gameManager.speedIncreaseRate * Time.deltaTime;
        this.transform.Translate(Time.deltaTime * currentSpeed,0,0);
    }
}
