using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class MainMenuScript : MonoBehaviour
{
    public GameObject lvlSelect;
    public GameObject mainMenu;
    public Button startBtn;
    public Button japanLvl;
    public Button pennLvl;
    public Button lebanonLvl;

    private void Start()
    {
        lvlSelect.SetActive(false);
    }

    public void ShowLvlSelect()
    { 
        mainMenu.SetActive(false);
        lvlSelect.SetActive(true);
    }  

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        lvlSelect.SetActive(false);
    }

    public void ShowPennLvl() {
        SceneManager.LoadScene(2);
    } 

    public void ShowLebanonLvl() {
        SceneManager.LoadScene(3);
    } 

    public void ShowJapanLvl() {
        SceneManager.LoadScene(1);
    }


    
}
