using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnswerFlash : MonoBehaviour
{

    float flashTimer = 1f;

    protected const float FLASH_TIME = 0.5f;

    Color wrongColor = new Color(0.25f, 0f, 0f);

    Color rightColor = new Color(0f,0.25f,0f);

    public bool correctAnswer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ScreenFlash(correctAnswer);

    }

    public void ScreenFlash(bool isTrue)
    {

        if (flashTimer > 0 && !isTrue)
        {
            flashTimer -= Time.deltaTime;

            gameObject.GetComponent<Image>().color = wrongColor;

            if (flashTimer <= 0)
            {
                gameObject.GetComponent<Image>().color = wrongColor;
                this.flashTimer = 1f;
                this.gameObject.SetActive(false);
                
            }
            else if (flashTimer < 0.2f)
            {
                gameObject.GetComponent<Image>().color = Color.clear;
            }
            else if (flashTimer < 0.4f)
            {
                gameObject.GetComponent<Image>().color = wrongColor;
            }
            else if (flashTimer < 0.6f)
            {
                gameObject.GetComponent<Image>().color = Color.clear;
            }
            else if (flashTimer < 0.8f)
            {
                gameObject.GetComponent<Image>().color = wrongColor;
            }
            else
            {
                gameObject.GetComponent<Image>().color = Color.clear;
            }
        }

        if (flashTimer > 0 && isTrue)
        {
            flashTimer -= Time.deltaTime;

            gameObject.GetComponent<Image>().color = rightColor;

            if (flashTimer <= 0)
            {
                gameObject.GetComponent<Image>().color = rightColor;
                this.gameObject.SetActive(false);
                this.flashTimer = 1f;
            }
            else if (flashTimer < 0.2f * FLASH_TIME)
            {
                gameObject.GetComponent<Image>().color = Color.clear;
            }
            else if (flashTimer < 0.4f * FLASH_TIME)
            {
                gameObject.GetComponent<Image>().color = rightColor;
            }
            else if (flashTimer < 0.6f * FLASH_TIME)
            {
                gameObject.GetComponent<Image>().color = Color.clear;
            }
            else if (flashTimer < 0.8f * FLASH_TIME)
            {
                gameObject.GetComponent<Image>().color = rightColor;
            }
            else
            {
                gameObject.GetComponent<Image>().color = Color.clear;
                
            }
        }


    }


}
