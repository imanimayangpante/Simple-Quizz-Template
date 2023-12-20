using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using for edit
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public SceneAsset MainMenu;
    public SceneAsset GameOverSc;
    public SceneAsset[] NumberLvSc;

    public void ToStarMenu() 
    {
        SceneManager.LoadScene(MainMenu.name);
    }

    public void ToLvChoose(int whichLv) 
    {
        SceneManager.LoadScene(NumberLvSc[whichLv-1].name);
    }
}


