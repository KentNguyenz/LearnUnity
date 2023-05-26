using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : BaseManager<GameManager> 
{
    private const string KiwiKey = "Kiwi";
    private int kiwies = 0;
    public int Kiwies => kiwies;
    private bool isPlaying = false;
    public bool IsPlaying => isPlaying;
    protected override void Awake()
    {
        base.Awake();
        kiwies = PlayerPrefs.GetInt(KiwiKey, 0);
    }

    public void UpdateKiwies(int value)
    {
        kiwies =value;
    }
    public void StartGame()
    {
        isPlaying= true;
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        if(isPlaying)
        {
            isPlaying= false;
            Time.timeScale = 0f;
        }
    }
    public void ResumeGame()
    {
        if(!isPlaying)
        {
            isPlaying = true;
            Time.timeScale = 1f;
        }
    }
    public void RestartGame()
    {
        ChangeScene("Menu");
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveMenuPanel(true);
            UIManager.Instance.ActiveGamePanel(false);
            UIManager.Instance.ActiveVictoryPanel(false);
            UIManager.Instance.ActiveLosePanel(false);
        }
    }
    public void EndGame()
    {
#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt(KiwiKey, Kiwies);
    }

}
