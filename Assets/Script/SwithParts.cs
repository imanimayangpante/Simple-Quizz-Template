using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SwithParts : MonoBehaviour
{
    public static SwithParts instance;
    public int currentQuiz = 1;
    public GameObject[] QuizzParts;
    public SceneAsset nextPart;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ShowQuiz();
    }
    public void ShowQuiz() 
    {
        if (currentQuiz > QuizzParts.Length) 
        {
            currentQuiz = 1;
        }

        for (int i = 0; i < QuizzParts.Length; i++)
        {
            QuizzParts[i].SetActive(false);
        }
        QuizzParts[currentQuiz-1].SetActive(true);
    }

}
