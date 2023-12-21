using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedugDataContainer : MonoBehaviour
{
    public  int currentLevel;
    public  int currentPart;
    public  int currentQuizz;

    public  int currentPlayerHealth;
    public  int mmaxPlayerHealth;

    private void Update()
    {
        currentLevel = DataContainer.currentLevel;
        currentPart = DataContainer.currentPart;
        currentQuizz = DataContainer.currentQuizz;

        currentPlayerHealth = DataContainer.currentPlayerHealth;
        mmaxPlayerHealth = DataContainer.mmaxPlayerHealth;
    }
}
