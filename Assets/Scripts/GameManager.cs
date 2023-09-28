using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    public static GameManager Instance;

    public float initialSpeed = 15.0f; // Velocidad inicial
    public float speedIncreaseRate = 0.1f; // Tasa de aumento de velocidad por segundo
    public float currentSpeed;

    public Text scoreText;
    private int score = 0;

    private void Awake(){
        if (Instance == null){
            Instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    public void Start(){
        scoreText.text = "Souls                        Press R to restart";
        currentSpeed = initialSpeed;
    }

    public void AddPoints(int points){
        score += points;
        UpdateScoreText();
    }

    public void YouLose(){
        scoreText.text = "You Lose                   Press R to restart";
    }

    void UpdateScoreText(){
        if (scoreText != null){
            scoreText.text = "Souls:" + score.ToString() + "                       Press R to restart";
        }
    }

    void FixedUpdate(){
        currentSpeed += speedIncreaseRate * Time.deltaTime;
        this.transform.Translate(Time.deltaTime * currentSpeed,0,0);
    }
}

