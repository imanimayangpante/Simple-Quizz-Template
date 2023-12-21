using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthShow : MonoBehaviour
{
    public static PlayerHealthShow instance;
    public GameObject[] playerRedHealth;
    public SceneAsset gameOverScn;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateRedPlayerHealth();
    }

    public void UpdateRedPlayerHealth() 
    {
        for (int i = 0; i < playerRedHealth.Length; i++) 
        {
            if (i < DataContainer.currentPlayerHealth)
            {
                playerRedHealth[i].SetActive(true);
            }
            else
            {
                playerRedHealth[i].SetActive(false);
            }
        }
    }

    public void DecreaseHealthPoint() 
    {
        DataContainer.currentPlayerHealth -= 1;
        if (DataContainer.currentPlayerHealth <= 0) 
        {
            SceneManager.LoadScene(gameOverScn.name);
        }
        UpdateRedPlayerHealth();
    }
}
