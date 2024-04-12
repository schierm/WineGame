using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using TMPro;

public class QuestionLogic : MonoBehaviour
{

    [SerializeField]
    public GameObject[] nextInfo;

    [SerializeField]
    public GameObject endScreen;

    [SerializeField]
    public AnswerFlash flashScreen;

    public int currentQuestion = 0;

    int correctAnswers = 0;

    int incorrectAnswers = 0;

    public TMP_Text scoreText;

    public void Start()
    {
        
    }

    public void CorrectAnswer()
    {

        correctAnswers++;
        
       // Debug.Log("Correct answer " + currentQuestion);
        
        flashScreen.gameObject.SetActive(true);

        flashScreen.correctAnswer = true;

        

        SlideChange();


    }

    public void IncorrectAnswer()
    {

        incorrectAnswers++;

        flashScreen.gameObject.SetActive(true);

        flashScreen.correctAnswer = false;

        //Debug.Log("Incorrect Answer " + currentQuestion);

        SlideChange();

    }

    public void SlideChange()
    {
        
        if (currentQuestion + 1 < nextInfo.Length)
        {
            Debug.Log("Slide Change " + currentQuestion);
            nextInfo[currentQuestion].SetActive(false);

            currentQuestion++;
            Debug.Log("Slide Change " + currentQuestion);
            nextInfo[currentQuestion].SetActive(true);

            Debug.Log("Next Info Length" + nextInfo.Length);

        }
        else
        {
            Debug.Log("Slide Change " + currentQuestion);
            Debug.Log("Next Info Length" + nextInfo.Length);
            nextInfo[currentQuestion].SetActive(false);

            scoreText.text = correctAnswers + "/5";
            endScreen.SetActive(true);
        }
    }

}
