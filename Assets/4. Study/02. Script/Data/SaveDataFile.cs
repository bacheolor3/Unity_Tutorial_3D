using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string CharID = "C01";
    public string Name = "Player";
    public int HP = 100;
    public int Attack = 20;
    public int score;
}

public class SaveDataFile : MonoBehaviour
{
    private int score;
    private string savePath;

    private void Start()
    {
        // Application.dataPath : Asset Folder
        // Application.persistentDataPath : local save Path recommended by platform for safe
        savePath = Path.Combine(Application.persistentDataPath, "saveDataFile.json");

        Load();
        Debug.Log("Load Score : " + score);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            // Save

            Debug.Log("Score : " + score);

            Save();
        }
    }

    private void Save()
    {
        SaveData data = new SaveData();
        data.score = score;

        string json = JsonUtility.ToJson(data, true);
        // string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);

        Debug.Log("Data saved to : " + savePath);
    }

    private void Load()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            this.score = data.score;
        }
        else
        {
            score = 0;
        }
    }
}
