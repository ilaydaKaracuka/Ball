using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton : MonoBehaviour
{
   public void Exit()
    {
        Application.Quit();
    }
    public void TryAgain()
    {
        SceneManager.LoadScene(0);
    }
}
