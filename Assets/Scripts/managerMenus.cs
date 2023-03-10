using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    public TextMeshProUGUI textLeaderBoardScore;
    public Button textLeaderBoardReset;
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
        textLeaderBoardReset.onClick.AddListener(resetLeaderBoard);

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
        
        ScoresUtil.addScore(new Score("Wykaz", 6000));

        updateLeaderBoards();
    }
    
    private void updateLeaderBoards()
    {
        List<Score> scores = ScoresUtil.getScore();
        textLeaderBoardScore.text = "";
        
        for (int i = 0; i < Mathf.Min(5, scores.Count) ; i++)
        {
            textLeaderBoardScore.text += scores[i].name + " : " + scores[i].score + "\n";
        }
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
        valeurSon.text = sliderSon.value.ToString();
        audioSource.volume = sliderSon.value / 100;
        try
        {
            SettingObject setting = new SettingObject((int)sliderSon.value);
            string json = JsonUtility.ToJson(setting);
            File.WriteAllText(Application.persistentDataPath + "\\setting.json", json);
        }
        catch (IOException e)
        {
            Debug.Log(e.ToString());
        }
    }
    #endregion

    #region leaderBoard fonction
    private void retourLeaderBoard()
    {
        leaderBoardMenus.SetActive(false);
        mainMenus.SetActive(true);
    }
    
    private void resetLeaderBoard()
    {
        ScoresUtil.reset();
        updateLeaderBoards();
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
                SceneManager.LoadScene("SceneNiveauFacile");
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
