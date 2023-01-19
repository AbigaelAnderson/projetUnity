using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompterLesPoints : MonoBehaviour
{
    [SerializeField]
    private float scorePartie;
    private string scoreaAfficher;
    private float positionMaxAtteinte;

    public TextMeshProUGUI scoreAffiché;

    // Start is called before the first frame update
    void Start()
    {
        scorePartie = 0;
        positionMaxAtteinte = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > positionMaxAtteinte)
        {
            positionMaxAtteinte = transform.position.z;
            actualiserScore();
        }
    }

    public void actualiserScore()
    {
        scorePartie = positionMaxAtteinte * 100;

        scoreaAfficher = Mathf.RoundToInt(scorePartie).ToString();

        scoreAffiché.SetText(scoreaAfficher);
    }
}
