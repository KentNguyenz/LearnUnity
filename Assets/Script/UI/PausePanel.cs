using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    public void OnClickedSettingButton()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveSettingPanel(true);
            UIManager.Instance.ActivePausePanel(false);
        }
    }
    public void OnclickedResumeButton()
    {
        if(GameManager.HasInstance)
        {
            GameManager.Instance.ResumeGame();
            UIManager.Instance.ActivePausePanel(false);
        }

    }
    public void OncClickedQuitButton()
    {
        if(GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
