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
        var scriptMove = instance.GetComponent<Rigidbody>();
        scriptMove.velocity = new Vector3(speed * 10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
