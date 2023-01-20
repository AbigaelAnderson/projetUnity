using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class setting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
        try
        {
            SettingObject setting = new SettingObject(100);
            string json = JsonUtility.ToJson(setting);
            File.WriteAllText(Application.persistentDataPath + "\\setting.json", json);
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
