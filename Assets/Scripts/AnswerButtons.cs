using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; // Blue is waiting
    public GameObject answerAbackGreen; // Green is Correct;
    public GameObject answerAbackRed; // Red in Wrong

    public GameObject answerBbackBlue; // Blue is waiting
    public GameObject answerBbackGreen; // Green is Correct;
    public GameObject answerBbackRed;
    public void AnswerA()
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
        }
    }
    public void AnswerB()
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
