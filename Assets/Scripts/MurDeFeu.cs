using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurDeFeu : MonoBehaviour
{

    /*setToSpawnPoint quand reessayer*/
    public GameObject personnage;
    public GameObject canvaEcranMort;

    private int positionZArrivee;

    Vector3 moveVector;
    [SerializeField]
    float vitesseDeplacement;

    // Start is called before the first frame update
    void Start()
    {
        positionZArrivee = 0;
        vitesseDeplacement = 0.01f;
        moveVector = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < positionZArrivee)
        {
            Move();

        }


    }

    public void Move()
    {
        // transform.Translate(moveVector * vitesseDeplacement);
        transform.position += moveVector * vitesseDeplacement;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Objet non identifié detecté");
        if (other.name == personnage.name)
        {
            Debug.Log("C'est pas une tortue comme toi qui arrivera de l'autre côté");
            canvaEcranMort.SetActive(true);
        }
    }
}
