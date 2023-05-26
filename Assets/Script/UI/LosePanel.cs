using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePanel : MonoBehaviour
{
    public void OnCLickRestartButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.RestartGame();     
        }
    }
    public void OnClickExitButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
