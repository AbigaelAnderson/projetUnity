using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!pauseMenus.Pause)
        {
            transform.Translate(speed * Time.deltaTime * 10, 0, 0);
        }
    }
}
