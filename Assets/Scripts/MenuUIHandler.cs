using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using TMPro;



#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public static string  currentName;
    public Text bestScoreText;
    void Start()
    {
        MainManager.Instance.LoadMaxScore();
        bestScoreText.text = $"Current best score: {MainManager.Instance.playerName}: {MainManager.Instance.maxScore}";
    }
    public void SaveName(string playerName)
    {
        currentName = playerName;
    }
    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
