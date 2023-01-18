using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerMenus : MonoBehaviour
{
    #region ui
    public GameObject mainMenus;
    public GameObject optionsMenus;

    public Button buttonQuit;
    public Button buttonOptions;

    public Button buttonRetourOptions;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        optionsMenus.SetActive(false);
        buttonQuit.onClick.AddListener(quit);
        buttonOptions.onClick.AddListener(options);
        buttonRetourOptions.onClick.AddListener(retourOptions);
    }

    #region main menus
    private void start()
    {

    }

    private void leaderBoards()
    {

    }
    private void options()
    {
        optionsMenus.SetActive(true);
        mainMenus.SetActive(false);
    }

    private void quit()
    {
        Application.Quit();
    }
    #endregion

    private void retourOptions()
    {
        optionsMenus.SetActive(false);
        mainMenus.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
