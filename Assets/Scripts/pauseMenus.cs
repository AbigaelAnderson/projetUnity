using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenus : MonoBehaviour
{
    public Button buttonExitGame;
    public Button buttonContinue;
    public GameObject menusPause;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        menusPause.SetActive(false);
        buttonExitGame.onClick.AddListener(exitGame);
        buttonContinue.onClick.AddListener(fonctionContinue);
    }

    private void fonctionContinue()
    {
        Debug.Log("continue");
        menusPause.SetActive(false);
    }
    private void exitGame()
    {
        SceneManager.LoadScene("menus");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("test");
            menusPause.SetActive(true);
        }
    }
}
