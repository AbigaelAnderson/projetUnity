using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArrivée : MonoBehaviour
{

    public GameObject personnage;
    public GameObject canvaEcranFin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnTriggerEnter(Collider other)
     {
        

         if(other.name == personnage.name)
         {
            Debug.Log("Perso a fini");
            canvaEcranFin.SetActive(true);
         }
     }


}
