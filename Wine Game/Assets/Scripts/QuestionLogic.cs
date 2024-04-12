using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

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

    public void Start()
    {
        
    }

    public void CorrectAnswer()
    {

        correctAnswers++;

        flashScreen.gameObject.SetActive(true);

        flashScreen.correctAnswer = true;

        SlideChange();


    }

    public void IncorrectAnswer()
    {

        incorrectAnswers++;

        flashScreen.gameObject.SetActive(true);

        flashScreen.correctAnswer = false;

        SlideChange();

    }

    public void SlideChange()
    {
        if (currentQuestion + 1 <= nextInfo.Length)
        {
            nextInfo[currentQuestion].SetActive(false);

            currentQuestion++;

            nextInfo[currentQuestion].SetActive(true);

        }
        else
        {
            Debug.Log(currentQuestion);
            Debug.Log(nextInfo.Length);
            nextInfo[currentQuestion].SetActive(false);

            endScreen.SetActive(true);
        }
    }

}
