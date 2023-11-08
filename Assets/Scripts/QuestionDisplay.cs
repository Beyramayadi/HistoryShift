using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    void Start()
    {
       
        StartCoroutine(PushTextOnScreen());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PushTextOnScreen()
    {
        
        yield return new WaitForSeconds(0.25f);
        
        screenQuestion.GetComponent<Text>().text = newQuestion;
        answer1.GetComponent<Text>().text = newA;
        answer2.GetComponent<Text>().text = newB;
        answer3.GetComponent<Text>().text = newC;
        answer4.GetComponent<Text>().text = newD;
    }
}
