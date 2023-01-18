using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerMenus : MonoBehaviour
{
    #region ui
    public GameObject mainMenus;
    public GameObject optionsMenus;
    public GameObject leaderBoardMenus;

    public Button buttonQuit;
    public Button buttonOptions;
    public Button buttonLeaderBoard;

    public Button buttonRetourOptions;

    public Button buttonLeaderBoardBack;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        optionsMenus.SetActive(false);
        leaderBoardMenus.SetActive(false);
        buttonQuit.onClick.AddListener(quit);
        buttonOptions.onClick.AddListener(options);
        buttonRetourOptions.onClick.AddListener(retourOptions);
        buttonLeaderBoardBack.onClick.AddListener(retourLeaderBoard);
        buttonLeaderBoard.onClick.AddListener(leaderBoards);
    }

    #region main menus
    private void startGame()
    {

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

    #region options
    private void retourOptions()
    {
        optionsMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    #endregion

    #region leaderBoard
    private void retourLeaderBoard()
    {
        leaderBoardMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
