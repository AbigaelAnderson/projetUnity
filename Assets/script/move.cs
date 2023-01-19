using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pauseMenus.Pause)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(speed * 10, 0, 0);
        }
    }
}
