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
            File.WriteAllText(Application.persistentDataPath + "\\setting.json","{\"setting:\"100}");
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
