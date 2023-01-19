using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 currentMovement;

    private bool movementDisabled;

    private bool alive;

    private const float moveIncrement = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        movementDisabled = false;
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        ResetRigidBody();
        CheckInputOrMove();
    }

    void CheckInputOrMove()
    {
        if (!movementDisabled && !pauseMenus.Pause)
        {
            bool move = false;
            if (currentMovement == Vector3.zero)
            {
                move = CheckInput();
            }
            else
            {
                move = true;
            }
            // Debug.Log(move);
            if (move)
            {
                MovePlayer();
            }
            else
            {
                RoundPosition();
            }
        }
        else
        {
            RoundPosition();
        }
    }

    bool CheckInput()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if (hori != 0)
        {
            if (hori < 0)
            {
                currentMovement = Vector3.left;
            }
            else
            {
                currentMovement = Vector3.right;
            }
        }
        else if (vert != 0)
        {
            if (vert < 0)
            {
                currentMovement = Vector3.back;
            }
            else
            {
                currentMovement = Vector3.forward;
            }
        }
        return currentMovement != Vector3.zero;
    }

    void MovePlayer()
    {
        // Debug.Log(currentMovement);
        Vector3 currentPos = transform.localPosition;

        // do a little jump!

        if (Mathf.Abs(currentMovement.x) > 0.5 + moveIncrement)
        {
            currentPos.y += moveIncrement;
        }
        else if (Mathf.Abs(currentMovement.x) != 0)
        {
            currentPos.y -= moveIncrement;
        }
        else if (Mathf.Abs(currentMovement.z) > 0.5 + moveIncrement)
        {
            currentPos.y += moveIncrement;
        }
        else if (Mathf.Abs(currentMovement.z) != 0)
        {
            currentPos.y -= moveIncrement;
        }


        // move along x or z axis based on the increment

        if (currentMovement.x < 0)
        {
            currentMovement.x += moveIncrement;
            currentPos.x -= moveIncrement;
        }
        else if (currentMovement.x > 0)
        {
            currentMovement.x -= moveIncrement;
            currentPos.x += moveIncrement;
        }
        else if (currentMovement.z < 0)
        {
            currentMovement.z += moveIncrement;
            currentPos.z -= moveIncrement;
        }
        else
        {
            currentMovement.z -= moveIncrement;
            currentPos.z += moveIncrement;
        }



        transform.localPosition = currentPos;

    }

    void RoundPosition()
    {
        Vector3 currentPos = transform.localPosition;
        currentPos.x = Mathf.Round(currentPos.x);
        currentPos.y = 0.5f;
        currentPos.z = Mathf.Round(currentPos.z);
        transform.localPosition = currentPos;
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }

    void ResetRigidBody()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().inertiaTensor = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Ground"))
        {
            Debug.Log("COLLISION!");
            // we hit something
            movementDisabled = true;

            // is it something that moves ?
            if (collision.relativeVelocity != Vector3.zero)
            {
                // Check if we're getting ran over by a car
                if (Mathf.Abs(collision.transform.localPosition.z - transform.localPosition.z) <= 0.5)
                {
                    // we got ran over by a car
                    Debug.Log("player died!");
                    alive = false;
                }
                else
                {
                    // we ran into the side of a car, but we're still alive
                    currentMovement = Vector3.zero;
                    RoundPosition();
                    ResetRigidBody();
                }
            }
            else
            {
                Debug.Log("TREE COLLISION!");
                // we ran into a tree, but we're alive
                currentMovement = Vector3.zero;
                RoundPosition();
                ResetRigidBody();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Invoke("EnableMovement", 0.2f);
    }

    private void EnableMovement()
    {
        movementDisabled = !alive;
    }

}
