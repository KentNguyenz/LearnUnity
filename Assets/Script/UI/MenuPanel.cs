using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    public void OnClickedStartGameButton()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveLoadingPanel(true);
            UIManager.Instance.ActiveMenuPanel(false);

        }
    }
    public void OnSettingButtonClick()
    {
        if(UIManager.Instance)
        {
            UIManager.Instance.ActiveSettingPanel(true);
        }
    }
    
}
