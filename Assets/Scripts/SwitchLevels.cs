using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevels : MonoBehaviour
{

    public string level1;
    public void playGame()
    {
        SceneManager.LoadScene(level1);
    }
}
