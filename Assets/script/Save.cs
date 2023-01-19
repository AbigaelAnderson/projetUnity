using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public Button btnDisplayOne;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        btnDisplayOne.onClick.AddListener(OnClickSave);
    }

    public void OnClickSave()
    {
        ScoresUtil.addScore(new Score("Wykaz", 12));
    }
}