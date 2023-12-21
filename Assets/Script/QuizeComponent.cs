using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.VirtualTexturing;

public class QuizeComponent : MonoBehaviour
{
    [Header("Question Part")]
    [Tooltip("Where is should be question Text")]
    public Image whereImageQuestion;
    public Sprite QuestionImageSprite;
    public Text whereIsQuestion; // should in OnValidate
    [TextArea(2,3)]
    public string questionText;
    

    [Space(10)]
    [Header("Button Answer 1")]
    public bool btn1BeAns; 
    public Image whereImageAns1; // should in OnValidate
    public Sprite btnAnsSprite1;
    public Text whereTextAns1; // should in OnValidate
    [TextArea(1, 3)]
    public string answerText1;

    [Space(10)]
    [Header("Button Answer 2")]
    public bool btn2BeAns;
    public Image whereImageAns2; // should in OnValidate
    public Sprite btnAnsSprite2;
    public Text whereTextAns2; // should in OnValidate
    [TextArea(1, 3)]
    public string answerText2;

    [Space(10)]
    [Header("Button Answer 3")]
    public bool btn3BeAns;
    public Image whereImageAns3; // should in OnValidate
    public Sprite btnAnsSprite3;
    public Text whereTextAns3; // should in OnValidate
    [TextArea(1, 3)]
    public string answerText3;

    private void OnValidate()
    {
        //question 
        whereImageQuestion.sprite = QuestionImageSprite;
        whereIsQuestion.text = questionText;

        //Ans Btn1
        whereImageAns1.sprite = btnAnsSprite1;
        whereTextAns1.text = answerText1;

        //Ans Btn2
        whereImageAns2.sprite = btnAnsSprite2;
        whereTextAns2.text = answerText2;

        //Ans Btn3
        whereImageAns3.sprite = btnAnsSprite3;
        whereTextAns3.text = answerText3;
    }

    
    public void BTN1() 
    {
        if (btn1BeAns)
        {
            //go to Next Quiz Part
            SwithParts.instance.currentQuiz += 1;
            SwithParts.instance.ShowQuiz();
        }
        else 
        {
            //Decrease player Health
            PlayerHealthShow.instance.DecreaseHealthPoint();
        }
    }

    public void BTN2()
    {
        if (btn2BeAns)
        {
            //go to Next Quiz Part
            SwithParts.instance.currentQuiz += 1;
            SwithParts.instance.ShowQuiz();
        }
        else
        {
            //Decrease player Health
            PlayerHealthShow.instance.DecreaseHealthPoint();
        }
    }

    public void BTN3()
    {
        if (btn3BeAns)
        {
            //go to Next Quiz Part
            SwithParts.instance.currentQuiz += 1;
            SwithParts.instance.ShowQuiz();
        }
        else
        {
            //Decrease player Health
            PlayerHealthShow.instance.DecreaseHealthPoint();
        }
    }

    public void BTNNext()
    {
        SwithParts.instance.currentQuiz += 1;
        SwithParts.instance.ShowQuiz();
    }



}
