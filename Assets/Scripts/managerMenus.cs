using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerMenus : MonoBehaviour
{
    public GameObject mainMenus;
    public Button buttonQuit;
    // Start is called before the first frame update
    void Start()
    {
        buttonQuit.onClick.AddListener(quit);
    }

    private void start()
    {

    }

    private void leaderBoards()
    {

    }
    private void options()
    {

    }

    private void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
