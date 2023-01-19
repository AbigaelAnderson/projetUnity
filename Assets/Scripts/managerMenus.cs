using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Slider sliderSon;
    public TextMeshProUGUI valeurSon;
    public AudioSource audioSource;
    #endregion

    #region leaderBoard
    public Button buttonLeaderBoardBack;
    #endregion

    #region level
    public Button buttonRetourLevel;
    public Button buttonFacile;
    public Button buttonMedium;
    public Button buttonHard;
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

        sliderSon.onValueChanged.AddListener(delegate { son(); });
        buttonRetourOptions.onClick.AddListener(retourOptions);

        buttonLeaderBoardBack.onClick.AddListener(retourLeaderBoard);

        #region level select
        buttonFacile.onClick.AddListener(delegate { loadLevel(Difficulte.easy); });
        buttonMedium.onClick.AddListener(delegate { loadLevel(Difficulte.medium); });
        buttonHard.onClick.AddListener(delegate { loadLevel(Difficulte.hard); });
        buttonRetourLevel.onClick.AddListener(retourLevel);
        #endregion
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

    private void son()
    {
        Debug.Log(sliderSon.value);
        valeurSon.text = sliderSon.value.ToString();
        audioSource.volume = sliderSon.value / 100;
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

    private void loadLevel(Difficulte newDiffculte)
    {
        switch(newDiffculte)
        {
            case Difficulte.easy:
                Debug.Log("load easy");
                break;
            case Difficulte.medium:
                Debug.Log("load medium");
                break;
            case Difficulte.hard:
                Debug.Log("load hard");
                break;
        }
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
