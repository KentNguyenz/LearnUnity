using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPanel : MonoBehaviour
{
    public void OnCLickedRestartButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.RestartGame();
        }
    }
    public void OnClickedExitButton()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
