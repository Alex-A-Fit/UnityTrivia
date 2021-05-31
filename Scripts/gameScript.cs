using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/*
Alex Ato 
9-18-2020
Challenge 4 Trivia
To create a 20 question Trivia Game that pools from a 50 question pool

Reviewed By Christy Eang---
"Typos in answers, Make question more contrasted to the backhround so it is easier to read."
---
*/
public class question{
    public string q;
    public string c1;
    public string c2;
    public string c3;
    public string c4;
    public string answer;

    public question(string question, string ch1, string ch2, string ch3, string ch4, string a)
    {
        q = question;
        c1 = ch1;
        c2 = ch2;
        c3 = ch3;
        c4 = ch4;
        answer = a;
    }
    
}
public class gameScript : MonoBehaviour
{
    public Text choice1;
    public Text choice2;
    public Text choice3;
    public Text choice4;
    public Text displayQ;
    public Text score;
    public Text countdownTimer;
    private bool startTime = false;
    public float timeAvailable = 20;
    
    public Button answer1;
    public Button answer2;
    public Button answer3;
    public Button answer4;
    public int maxQuestions = 20;
    public int counter = 0;
    public int rightAnswers = 0;
    public GameObject endGamePanel;
    public GameObject gamePanel2;

    public List<question> fullSet = new List<question>();
    public List<question> triviaQ = new List<question>();

    // Start is called before the first frame update
    void Start()
    {
        gamePanel2.SetActive(false);
        question q1 = new question("What is Ezio's full name?", "Ezio Auditore", "Ezio Auditore da Firenze", "Ezio Auditore Firenze", "Ezio Auditore de Firenze", "Ezio Auditore da Firenze");
        question q2 = new question("What Brotherhood did Ezio work for?", "Spanish Brotherhood" ,"French Brotherhood", "Assassin's Brotherhood", "Italian Brotherhood","Italian Brotherhood" );
        question q3 = new question("Who is Ezio not an ancestor to?", " Desmond Miles", "William Miles", "Clay Kaczmarek", "Altair", "Altair");
        question q4 = new question("From what years did Ezio hold the title of Master Assassin of the Italian Brotherhood?", "1500-1510", "1503-1510", "1503-1513", "1500-1513", "1503-1513");
        question q5 = new question("When was Ezio born?", "1459", "1457", "1460", "1461", "1459" );
        question q6 = new question("When did Ezio die?", "1524","1529","1525","1520","1524");
        question q7 = new question("How old was Ezio when he passed away?", "68", "65", "72", "60", "65");
        question q8 = new question("Who was Ezio's first lover?", " Sofia Sartor", "Christina Vespucci", "Claudia Auditore","Flavia Safor", "Christina Vespucci");
        question q9 = new question("Which of Ezio's family members were executed by hanging?", "Mother", "Sister", "Brother", "Cousin", "Brother");
        question q10 = new question("Where did Ezio and the rest of his family stay refuge at when Ezio's family was executed?", "La Villa", "Villa de Auditore", "Villa Auditore", "Villa a Fresa", "Villa Auditore");
        question q11 = new question("What Order did Ezio end up working for by the end of Assassin's Creed 2?", "Assassin Order", "Templar Order", "Italian Order", "Italian Assassin Order", "Assassin Order");
        question q12 = new question("What famous artist did Ezio meet?", "Leonardo da Vinci", "Michelangelo", "Raphael", "Donatello", "Leonardo da Vinci");
        question q13 = new question("Where did Ezio race his brother to?", "A bank", "A brothel", "A church", "The Center Market", "A Church");
        question q14 = new question("Who won in the race between Ezio and Federico?", "Neither", "Ezio", "Frederico", "It was a tie", "Ezio");
        question q15 = new question("Where was Ezio's brothers and father taken for arrest?", "Palaza de Signoria", "The Prigione", "La Palla", "Palazzo dell Signoria", "Palazzo dell Signoria");
        question q16 = new question("Who betrayed Ezio's family?", "Alberto Altini", "Alberto Ultini", "Ulberto Alberti", "Alonzo Marti", "Ulberto Alberti");
        question q17 = new question("Who killed Ulberto Alberti?", "Mario", "Ezio", "Christina", "The Templars", "Ezio");
        question q18 = new question("Who was Ezio's first kill?", "Ulberto", "a Templar", "a local Guard", "Dante Moro", "a local Guard");
        question q19 = new question("How many hidden blades did Ezio have in the mid year of 1478?", "1", "4", "2", "5", "2");
        question q20 = new question("What guild did Ezio Work with to kill Emilio Barbarigo?", "Thieves Guild", "Hunters Guild", "Assassin Guild", "Fighters Guild", "Thieves Guild");
        question q21 = new question("How did Ezio enter the Palazzo Ducale?", "Climbed over the wall", "He flew in", "Snuck in through the front", "Through an Undergorund entrance", "He flew in");
        question q22 = new question("Who won the Golden Mask at the Carnevale of 1486?", "Ezio", "Dante Moro", "Christina Vespucci", "Leonardo", "Dante Moro");
        question q23 = new question("How did Ezio kill Marco Barbarigo?", "Speared him", "Choked him", "Used his hidden blade", "He shot him", "He shot him");
        question q24 = new question("What were the Templars Trying to retrieve in Cyprus?", "An Amulet", "A Rod", "An Apple", "Necklace of Eden", "An Apple");
        question q25 = new question("When did Ezio join the Assassin Brotherhood?", "1490", "1486", "1492", "1488", "1488");
        question q26 = new question("Who was the prophet that the Codex mentioned?", "Altair", "Desmond", "Ezio", "Minerva", "Ezio" );
        question q27 = new question("What was the Piece of Eden that Ezio took from Rodrigo?","An Amulet", "A Rod", "An Apple", "Necklace of Eden", "An Apple" );
        question q28 = new question("Who took the Apple of Eden from Ezio?", "A Monk in black robes", "A Monk in white robes","A Monk in red robes","A Monk in yellow robes","A Monk in black robes");
        question q29 = new question("Where did Caterina's guards find Ezio dying?", "Outside Forli", "Entrance of Forli", "The mountains outside Forli", "on a maid", "The mountains outside Forli");
        question q30 = new question("What was the only lead Ezio had on the monk that took his apple?", "The Monk wore a ring", "The Monk had a missing finger", "The robes color", "The Monk's engraved ring", "The Monk had a missing finger");
        question q31 = new question("What happen to the Assassins in Spain in the year of 1491", "They Fled", "They were in hiding", "They were killed off by Inquisitors", "They disbanded", "They were killed off by Inquisitors");
        question q32 = new question("Why did Ezio postpone his search for the apple?", "To save his wife", "To rescue the remaining Assassins in Spain", "To help his uncle", "He heard the apple was in Spain", "To rescue the remaining Assassins in Spain");
        question q33 = new question("Who did Ezio find in the Argonese headquarters?", "Templars ransacking the building", "No one", "The remaining Assassins", "The Apple", "No one");
        question q34 = new question("What did Ezio find on the corpse of Gaspar Martinez?", "Templar necklace", "Picture of Ezio", "A list of 6 Assassins", "A piece of Eden", "A list of 6 Assassins");
        question q35 = new question("How many Assassins of Zaragoza did Ezio save?", "2", "6", "3", "5", "5");
        question q36 = new question("Who tipped off the inquisitors about the assassins?", "Marco Polo", "Rodrigo Borgia", "Templar messenger", "Leonardo da Vinci", "Rodrigo Borgia");
        question q37 = new question("Why didn't Ezio leave Spain after freeing the Assassins?","To investigate the Spanish Templars", "The Apple was found", "He found the love of his life", "He was injured", "To investigate the Spanish Templars");
        question q38 = new question("How did Ezio end the Granada War between Muhammad XII and Queen Isabella of Castile?", "Ezio persuaded Muhammad", "Ezio killed Muhammad", "Ezio killed Queen Isabella", "Ezio persuaded Queen Isabella", "Ezio persuaded Muhammad");
        question q39 = new question("What was the name of the French Assassin that has been stalking Ezio?", "Helen Dufranc", "Helen Dufrance", "Helene Dufrach", "Helene Dufranc", "Helene Dufranc");
        question q40 = new question("What happened to the people of Florence?", "They were killed off", "They were poisoned", "They were sold as slaves", "They were brainwashed", "They were sold as slaves");
        question q41 = new question("Who was responsible for the missing people of Florence?", "Helene Dufranc", "Rodrigo Borgia", "Bonacolto Contarini", "BonaParte Respuchi", "Bonacolto Contarini");
        question q42 = new question("What happened in Ezio's hometown in 1497?", "They were being slaughtered", "They were being brainwashed", "They were captured and sold as slaves", "They were gone", "They were being brainwashed");
        question q43 = new question("What happened to Christina Vespucci?", "She died in Ezio's arms", "She fled Italy", "She was captured", "She was brainwashed to kill Ezio", "She died in Ezio's arms");
        question q44 = new question("How did Ezio solve the Codex Puzzle?", "By using the Apple", "By using eagle vision", "By pure luck", "By using the Rod of Eden", "By using eagle vision");
        question q45 = new question("Where was the Vault located?", "In the Vatican", "Next to the Vatican", "On top of the Vatican", "Below the Vatican", "Below the Vatican"); 
        question q46 = new question("What was the second piece of Eden?", "Papal Staff", "Rod of Eden", "A golden necklace", "The Tree of Eden", "Papal Staff");
        question q47 = new question("What did Ezio find in the Vault?", "Altair", "A holographic woman named Minerva", "The rest of the pieces of Eden", "An empty Vault", "A holographic woman named Minerva");
        question q48 = new question("Who is Minerva?", "Roman God", "Greek God", "A member of the First Civilization", "Ezio", "A member of the First Civilization");
        question q49 = new question("What happened to the Staff of Eden?", "It broke", "It sunk into the Vault", "Ezio took it with him", "Rodrigo Borgia took it", "It sunk into the Vault");
        question q50 = new question("Who did Ezio give the apple to?", "Mario", "Leonardo da Vinci", "Christopher Columbus", "The Assassin Order", "Mario");

        fullSet.Add(q1);
        fullSet.Add(q2);
        fullSet.Add(q3);
        fullSet.Add(q4);
        fullSet.Add(q5);
        fullSet.Add(q6);
        fullSet.Add(q7);
        fullSet.Add(q8);
        fullSet.Add(q9);
        fullSet.Add(q10);
        fullSet.Add(q11);
        fullSet.Add(q12);
        fullSet.Add(q13);
        fullSet.Add(q14);
        fullSet.Add(q15);
        fullSet.Add(q16);
        fullSet.Add(q17);
        fullSet.Add(q18);
        fullSet.Add(q19);
        fullSet.Add(q20);
        fullSet.Add(q21);
        fullSet.Add(q22);
        fullSet.Add(q23);
        fullSet.Add(q24);
        fullSet.Add(q25);
        fullSet.Add(q26);
        fullSet.Add(q27);
        fullSet.Add(q28);
        fullSet.Add(q29);
        fullSet.Add(q30);
        fullSet.Add(q31);
        fullSet.Add(q32);
        fullSet.Add(q33);
        fullSet.Add(q34);
        fullSet.Add(q35);
        fullSet.Add(q36);
        fullSet.Add(q37);
        fullSet.Add(q38);
        fullSet.Add(q39);
        fullSet.Add(q40);
        fullSet.Add(q41);
        fullSet.Add(q42);
        fullSet.Add(q43);
        fullSet.Add(q44);
        fullSet.Add(q45);
        fullSet.Add(q46);
        fullSet.Add(q47);
        fullSet.Add(q48);
        fullSet.Add(q49);
        fullSet.Add(q50);

        for(int i = 0; i<= maxQuestions; i++){
            int r = UnityEngine.Random.Range(0,fullSet.Count - 1);
            triviaQ.Add(fullSet[r]);
            fullSet.Remove(fullSet[r]);
        }
      
        loadQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Your score was " + Convert.ToString(rightAnswers) + "/" + Convert.ToString(maxQuestions);
        if (counter == 20){
            endGamePanel.SetActive(true);
            gamePanel2.SetActive(false);
            startTime = false;
        }
        if (startTime){
        timeAvailable -= Time.deltaTime;
        countdownTimer.text = timeAvailable.ToString("f0");
        }
        if (timeAvailable <= 0){
            counter++;
            loadQuestion();
            timeAvailable = 20;
        }

    }
    void loadQuestion(){
        choice1.text = triviaQ[counter].c1;
        choice2.text = triviaQ[counter].c2;
        choice3.text = triviaQ[counter].c3;
        choice4.text = triviaQ[counter].c4;
        displayQ.text = triviaQ[counter].q;
    }

    public void clickedanswer1(){
        if (choice1.text == triviaQ[counter].answer){
            Debug.Log("Good Job");
            counter++;
            rightAnswers++;
            loadQuestion();
            timeAvailable = 20;
            
    }else{
         Debug.Log("INCORRECT");
         counter++;
         loadQuestion();
         timeAvailable = 20;
    }
    }
    public void clickedanswer2(){
        if (choice2.text == triviaQ[counter].answer){
            Debug.Log("Good Job");
            counter++;
            rightAnswers++;
            loadQuestion();
            timeAvailable = 20;
    }else{
         Debug.Log("INCORRECT");
         counter++;
         loadQuestion();
         timeAvailable = 20;
    }
    }
    public void clickedanswer3(){
        if (choice3.text == triviaQ[counter].answer){
            Debug.Log("Good Job");
            counter++;
            rightAnswers++;
            loadQuestion();
            timeAvailable = 20;
    }else{
         Debug.Log("INCORRECT");
         counter++;
         loadQuestion();
         timeAvailable = 20;
    }
    }
    public void clickedanswer4(){
        if (choice4.text == triviaQ[counter].answer){
            Debug.Log("Good Job");
            counter++;
            rightAnswers++;
            loadQuestion();
            timeAvailable = 20;
    }else{
         Debug.Log("INCORRECT");
         counter++;
         loadQuestion();
         timeAvailable = 20;
    }
    }
   
    public void startTimer(){
        timeAvailable = 20;
        startTime = true;
    }

}
