using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using for edit

using UnityEditor;

using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string mainMenuScn;
    public string chooseLvScn;
    public string[] numberLvScn;
    //public SceneAsset mainMenuScn;
    //public SceneAsset chooseLvScn;
    //public SceneAsset[] numberLvScn;

    public void ToStartMenu() 
    {
        SceneManager.LoadScene(mainMenuScn);
    }

    public void ToChooseLvScene() 
    {
        SceneManager.LoadScene(chooseLvScn);
    }

    public void ToLvScene(int whichLv)
    {
        SceneManager.LoadScene(numberLvScn[whichLv-1]);
        DataContainer.currentLevel = whichLv;
    }

    public void QuitGame() 
    {
        Application.Quit();
        Debug.Log("Game had Quit");
    }

    public void GoToPart(string PartScene) 
    {
        DataContainer.currentPlayerHealth = 5;
        SceneManager.LoadScene(PartScene);
    }

    //public void GoToPart(SceneAsset PartScene)
   // {
   //     DataContainer.currentPlayerHealth = 5;
  //      SceneManager.LoadScene(PartScene.name);
   // }
}


