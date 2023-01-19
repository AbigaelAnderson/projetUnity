using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    public Button backToMenu;
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
        SceneManager.LoadScene("menus");
    }
}
