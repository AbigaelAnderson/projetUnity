using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class readSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            string fileContent = File.ReadAllText(Application.persistentDataPath + "\\setting.json");
            SettingObject objet = JsonUtility.FromJson<SettingObject>(fileContent);
            Debug.Log(objet.audioSetting);
        }
        catch(IOException e)
        {
            Debug.Log(e.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
