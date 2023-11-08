using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenerator : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;





    void Start()
    {
      
    }
    void Update()
    {
        if (displayingQuestion == false)
         {
          displayingQuestion = true;
         QuestionDisplay.newQuestion = "Who was the famous Carthaginian general who led his forces, including war elephants, across the Alps during the Second Punic War in an attempt to attack Rome?";
         QuestionDisplay.newA = "A. Hannibal Barca";
         QuestionDisplay.newB = "B. Scipio Africanus";
         QuestionDisplay.newC = "C. Julius Caesar";
         QuestionDisplay.newD = "D. Alexander the Great";
         actualAnswer = "A";

         }

    }
}
