using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class managerMort : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonMenus;
    public Button buttonReTry;
    void Start()
    {
        buttonMenus.onClick.AddListener(menus);
        buttonReTry.onClick.AddListener(reTry);
    }

    private void menus()
    {
        SceneManager.LoadScene("menus");
    }

    private void reTry()
    {
        SceneManager.LoadScene("SceneNiveauFacile");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
