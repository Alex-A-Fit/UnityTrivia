using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Alex Ato 
9-18-2020
Challenge 4 Trivia
To create a 20 question Trivia Game that pools from a 50 question pool

Reviewed By Christy Eang---
"Typos in answers, Make question more contrasted to the backhround so it is easier to read."
---
*/

public class changeScene : MonoBehaviour
{
     public void loadScene(string sceneName){
    SceneManager.LoadScene(sceneName);
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
