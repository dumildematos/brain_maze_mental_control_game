using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public static int score = 0;

    public float startingTime;
    private float currentTime;
    public GameObject countDownText;
    public GameObject countCollected;

    private void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {

        scoreText.GetComponent<Text>().text = "Score: " + score;

        currentTime -= 1 * Time.deltaTime;
        countDownText.GetComponent<Text>().text = "Time: " + currentTime.ToString ("0");
        if(currentTime <= 0)
        {
            currentTime = 0;
        }

        countCollected.GetComponent<Text>().text = "Collected: " + (score / 50) + "/" + 10; 


    }

}
