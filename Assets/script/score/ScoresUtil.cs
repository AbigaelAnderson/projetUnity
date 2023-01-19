using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoresUtil : MonoBehaviour
{
    private static string path;
    
    void Start()
    {
        path = Application.persistentDataPath + "/score.json";
    }

    public static void addScore(Score score)
    {
        string jsonGet = File.ReadAllText(path);

        Scores scores = JsonUtility.FromJson<Scores>(jsonGet);
        
        scores.list.Add(score);
        
        string jsonSave = JsonUtility.ToJson(scores);

        File.WriteAllText(path, jsonSave);
        Debug.Log("Saved " + jsonSave);
    }
    
    public static List<Score> getScore(string path)
    {
        string jsonGet = File.ReadAllText(path);

        Scores scores = JsonUtility.FromJson<Scores>(jsonGet);

        return scores.list;
    }
}
