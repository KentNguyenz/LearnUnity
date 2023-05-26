
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Security.Cryptography.X509Certificates;

public class TestSO : MonoBehaviour
{
    public TextMeshProUGUI PlayerMaxHealth;
    public TextMeshProUGUI PlayerMoveSpeed;
    public TextMeshProUGUI EnemyDamage;
    private void Start()
    {
        if(DataManager.Instance != null)
        {
            DataManager.Instance.Init();
            LoadData();
        }
    }
    private void LoadData()
    {
        var globalConfig = DataManager.Instance.GlobalConfig;
        PlayerMaxHealth.text = "PlayerMaxHealth : " + globalConfig.globalConfig.PlayerMaxHealth;
        PlayerMoveSpeed.text ="PlayerMoveSpeed: " + globalConfig.globalConfig.PlayerMoveSpeed;
        EnemyDamage.text = "EnemyDamage: "+ globalConfig.globalConfig.EnemyDamage;
    }
    public void UpdateConfigData(int amount)
    {
        var globalConfig = DataManager.Instance.GlobalConfig;
        globalConfig.globalConfig.PlayerMaxHealth += amount;
        globalConfig.globalConfig.PlayerMoveSpeed += amount;
        globalConfig.globalConfig.EnemyDamage += amount;
        DataManager.Instance.SaveData();
        LoadData();
    }
}
