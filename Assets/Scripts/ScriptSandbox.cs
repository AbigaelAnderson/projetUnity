using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSandbox : MonoBehaviour
{
    public GameObject canvaEcranFin;
    public GameObject canvaEcranMort;

    // Start is called before the first frame update
    void Start()
    {
        canvaEcranFin.SetActive(false);
        canvaEcranMort.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
