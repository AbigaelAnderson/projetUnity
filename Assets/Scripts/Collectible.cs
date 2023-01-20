using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private Vector3 moveVector;
    private Vector3 rotateVector;
    private float rotateSpeed;
    private float jumpSpeed;
    private float jumpHeight;

    private GameObject collectible;
    public GameObject personnage;

    // Start is called before the first frame update
    void Start()
    {
        jumpHeight = 0.8f;
        jumpSpeed = 0.005f;
        rotateVector = new Vector3(0, 1, 0);
        moveVector = Vector3.up;
        collectible = gameObject.GetComponent<GameObject>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= jumpHeight || transform.position.y <= 0.3)
        {
            moveVector = -moveVector;
        }

        AnimateCollectible();
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Objet touché");

        if (other.name == personnage.name)
        {
            Debug.Log("Objet collecté");

            Destroy(this.gameObject);

            CompterLesPoints.bonus += 1000;
        }
    }

    public void AnimateCollectible()
    {
        rotateVector += rotateVector * rotateSpeed;
        transform.position += moveVector * jumpSpeed;
        transform.Rotate(rotateVector);
       // transform.rotation += Vect

    }
}
