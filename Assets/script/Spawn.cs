using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float speed;
    public float interval;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2, interval);
    }

    void spawn()
    {
        var instance = Instantiate(car, transform.position, Quaternion.identity);
        var scriptMove = instance.AddComponent<Move>();
        scriptMove.speed = 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
