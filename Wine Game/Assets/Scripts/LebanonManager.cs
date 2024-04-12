using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LebanonManager : MonoBehaviour
{
    public GameObject[] infoText;

    public QuestionLogic questionLogic;

    public GameObject questionSlide;
    public TMP_Text questionTitle;
    public TMP_Text questionText;

    private int currentSlide;
    private int currentQuestion;
    private string[] questions = new string[5];


    public Button[] answerBtns;
    public Button readyBtn;

    // Start is called before the first frame update
    void Start()
    {
        currentSlide = 0;
        currentQuestion = 1;

        questions[0] = "What Empire took control of Lebanon, stopping all wine production?";
        questions[1] = "this is question 2";

        // Hide all the info we dont wanna show yet
        for(int i = 1; i < infoText.Length; i++)
        {
            infoText[i].SetActive(false);
        }
       // infoText[1].SetActive(false);
       // infoText[2].SetActive(false);
        questionSlide.SetActive(false);
    }

    public void SetupQuestion(int number, string question)
    {
        questionTitle.SetText("Question #" + number);
        questionText.SetText(question);
    }

    public void NextInfoSlide()
    {
        infoText[currentSlide].SetActive(false);
        currentSlide++;
        infoText[currentSlide].SetActive(true);
    }

    public void StartLevel()
    {
        infoText[currentSlide].SetActive(false);
        questionSlide.SetActive(true);

        SetupQuestion(currentQuestion, questions[currentQuestion]);
    }

    public void StartLevel1()
    {
        infoText[2].SetActive(false);
        questionSlide.SetActive(true);

        SetupQuestion(1, "What Empire took control of Lebanon, stopping all wine production?");
    }

    public void StartLevel2()
    {
        infoText[1].SetActive(false);
    }

    public void StartLevel3()
    {
        infoText[2].SetActive(false);
    }
}
