using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using for edit

using UnityEditor;

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public SceneAsset mainMenuScn;
    public SceneAsset chooseLvScn;
    public SceneAsset[] numberLvScn;

    public void ToStartMenu() 
    {
        SceneManager.LoadScene(mainMenuScn.name);
    }


    public void ToChooseLvScene() 
    {
        SceneManager.LoadScene(chooseLvScn.name);
    }

    public void ToLvScene(int whichLv)
    {
        SceneManager.LoadScene(numberLvScn[whichLv-1].name);
        DataContainer.currentLevel = whichLv;
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Game had Quit");
    }
}


