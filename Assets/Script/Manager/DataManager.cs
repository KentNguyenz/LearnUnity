using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public GlobalConfigSO GlobalConfig;
    private string dataPath;
    private void Awake()
    {
        if(Instance !=null)
        {
            Destroy(this);
        }
        else
        {
            Instance= this;
            DontDestroyOnLoad(this);
        }
    }
    public void Init()
    {
        dataPath = Application.persistentDataPath + "/GlobalConfig.json";
        LoadData();
    }
    private void WriteData()
    {
        string toJSON= JsonUtility.ToJson(GlobalConfig);
        File.WriteAllText(dataPath, toJSON);
    }
    private string ReadData()
    {
        if (File.Exists(dataPath))
        {
            return File.ReadAllText(dataPath);
        }
        return null;
    }
    public void LoadData()
    {
        string fromJSON=ReadData();
        JsonUtility.FromJsonOverwrite(fromJSON, GlobalConfig);
       
    }
    public void SaveData()
    {
        WriteData();
    }
}
