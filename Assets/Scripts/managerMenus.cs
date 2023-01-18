using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerMenus : MonoBehaviour
{
    #region ui
    #region gameObject
    public GameObject mainMenus;
    public GameObject optionsMenus;
    public GameObject leaderBoardMenus;
    public GameObject levelMenus;
    #endregion

    #region menus principal
    public Button buttonQuit;
    public Button buttonOptions;
    public Button buttonLeaderBoard;
    public Button buttonLevel;
    #endregion

    #region options
    public Button buttonRetourOptions;
    #endregion

    #region leaderBoard
    public Button buttonLeaderBoardBack;
    #endregion

    #region level
    public Button buttonRetourLevel;
    #endregion
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        #region setup menus
        optionsMenus.SetActive(false);
        leaderBoardMenus.SetActive(false);
        levelMenus.SetActive(false);
        #endregion

        #region setup button menus principal
        buttonQuit.onClick.AddListener(quit);
        buttonOptions.onClick.AddListener(options);
        buttonLeaderBoard.onClick.AddListener(leaderBoards);
        buttonLevel.onClick.AddListener(startGame);
        #endregion

        buttonRetourOptions.onClick.AddListener(retourOptions);

        buttonLeaderBoardBack.onClick.AddListener(retourLeaderBoard);
        
        buttonRetourLevel.onClick.AddListener(retourLevel);
    }

    #region main menus fonction
    private void startGame()
    {
        levelMenus.SetActive(true);
        mainMenus.SetActive(false);
    }

    private void leaderBoards()
    {
        leaderBoardMenus.SetActive(true);
        mainMenus.SetActive(false);
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

    #region options fonction
    private void retourOptions()
    {
        optionsMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    #endregion

    #region leaderBoard fonction
    private void retourLeaderBoard()
    {
        leaderBoardMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    #endregion

    #region level fonction
    private void retourLevel()
    {
        levelMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
