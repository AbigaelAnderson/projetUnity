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
    public static bool Pause;
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
        pauseMenus.Pause = false;
    }
    private void exitGame()
    {
        pauseMenus.Pause = true;
        SceneManager.LoadScene("menus");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("test");
            menusPause.SetActive(true);
            pauseMenus.Pause = true;
        }
    }
}
