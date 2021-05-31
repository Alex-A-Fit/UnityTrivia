using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Alex Ato 
9-18-2020
Challenge 4 Trivia
To create a 20 question Trivia Game that pools from a 50 question pool

Reviewed By Christy Eang---
"Typos in answers, Make question more contrasted to the backhround so it is easier to read."
---
*/
public class menuPage : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject titlePanel;
    public GameObject optionsPanel;
    public GameObject gamePanel;
    public GameObject endGamePanel2;
    
    

    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        gamePanel.SetActive(false);
        endGamePanel2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void exit()
    {
        Application.Quit();
    }

    public void toGamePanel(){
        gamePanel.SetActive(true);
        menuPanel.SetActive(false);
    }
    public void toTitlePanel(){
        titlePanel.SetActive(true);
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        gamePanel.SetActive(false);
    }
    public void toMenuPanel(){
        menuPanel.SetActive(true);
        titlePanel.SetActive(false);
    }
    public void toOptionsPanel(){
        optionsPanel.SetActive(true);
        titlePanel.SetActive(false);
    }
}
