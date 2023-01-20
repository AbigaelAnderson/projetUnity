using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompterLesPoints : MonoBehaviour
{
    public static float scorePartie;
    public static float bonus;
    private string scoreaAfficher;
    private float positionMaxAtteinte;

    public TextMeshProUGUI scoreAffiche;
    public TextMeshProUGUI scoreFin;

    // Start is called before the first frame update
    void Start()
    {
        scorePartie = 0;
        bonus = 0;
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
        scorePartie = positionMaxAtteinte * 100 + bonus;

        scoreaAfficher = Mathf.RoundToInt(scorePartie).ToString();

        scoreAffiche.SetText("Score: " + scoreaAfficher);
        scoreFin.SetText(scoreaAfficher);
    }
}
