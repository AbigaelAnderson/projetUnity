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
        if(!pauseMenus.Pause)
        {
            var instance = Instantiate(car, transform.position, Quaternion.identity);
            var scriptMove = instance.GetComponent<Rigidbody>();
            var scriptMove2 = instance.AddComponent<move1>();
            scriptMove2.speed = speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
