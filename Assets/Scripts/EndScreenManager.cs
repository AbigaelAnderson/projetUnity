using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    public Button backToMenu;

    public TextMeshProUGUI textPseudo;
    // Start is called before the first frame update
    void Start()
    {
        backToMenu.onClick.AddListener(returnToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void returnToMenu()
    {
        // TODO : Save score
        string pseudo = textPseudo.text;
        if (pseudo == "")
        {
            pseudo = "Anonymous";
        }
        ScoresUtil.addScore(new Score(pseudo, CompterLesPoints.scorePartie));
        SceneManager.LoadScene("menus");
    }
}
