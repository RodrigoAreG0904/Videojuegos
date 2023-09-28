using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour{

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


    void LateUpdate(){
        currentSpeed += gameManager.speedIncreaseRate * Time.deltaTime;
        this.transform.Translate(0, 0, Time.deltaTime * currentSpeed*-1);
    }
}
