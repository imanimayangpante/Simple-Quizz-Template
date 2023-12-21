using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.VirtualTexturing;


public class SectionComponent : MonoBehaviour
{
    [Tooltip("where head Question is")]
    public Text mainQuestion;
    [TextArea(1,3)]
    public string mainQuestionText;

    [Space(10)]
    [Tooltip("where question should change")]
    public Text questionTextField;
    public GameObject questionImage;
    public Sprite questionSprite;
    [TextArea(1, 3)]
    public string questionText;


    [Space(10)]
    public GameObject btn1;
    public Sprite btn1Sprite;
    public Text btn1Text;
    public string btn1String;

    [Space(10)] 
    public GameObject btn2;
    public Sprite btn3Sprite;
    public Text btn2Text;
    public string btn2String;

    [Space(10)]
    public GameObject btn3;
    public Sprite btn2Sprite;
    public Text btn3Text;
    public string btn3String;

    private void OnValidate()
    {
        mainQuestion.text = mainQuestionText;
        questionImage.GetComponent<Image>().sprite = questionSprite;
        questionTextField.text = questionText;
        btn1.GetComponent<Image>().sprite = btn1Sprite;
        btn2.GetComponent<Image>().sprite = btn2Sprite;
        btn3.GetComponent<Image>().sprite = btn3Sprite;

        btn1Text.text = btn1String;
        btn2Text.text = btn2String;
        btn3Text.text = btn3String;
    }
    
}

