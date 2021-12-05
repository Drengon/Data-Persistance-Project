using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BestScoreManager : MonoBehaviour
{
    public Input PlayerName;
    public Input BestScore;

    public void SavePlayerName()
    {
        BestScoreManager data = new BestScoreManager();
        data.PlayerName = PlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }
    public void LoadPlayerName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            BestScoreManager data = JsonUtility.FromJson<BestScoreManager>(json);

            PlayerName = data.PlayerName;

        }
    }
    public void SaveBestScore()
    {
        BestScoreManager data = new BestScoreManager();
        data.BestScore = BestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            BestScoreManager data = JsonUtility.FromJson<BestScoreManager>(json);

            BestScore = data.BestScore;

        }

    }
}
