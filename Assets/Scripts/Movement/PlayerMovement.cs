using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 currentMovement;

    private bool movementInputDisabled;

    private const float moveIncrement = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        movementInputDisabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputOrMove();
    }

    void CheckInputOrMove()
    {
        bool move = false;
        if (currentMovement == Vector3.zero)
        {
            if (!movementInputDisabled)
            {
                move = CheckInput();
            }
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
        } else if (Mathf.Abs(currentMovement.x) != 0)
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
        } else if (currentMovement.x > 0)
        {
            currentMovement.x -= moveIncrement;
            currentPos.x += moveIncrement;
        } else if (currentMovement.z < 0)
        {
            currentMovement.z += moveIncrement;
            currentPos.z -= moveIncrement;
        } else
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
        currentPos.z = Mathf.Round(currentPos.z);
        transform.localPosition = currentPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Ground"))
        {
            Debug.Log("COLLISION!");
            // we hit something
            movementInputDisabled = true;
        } 
    }
}
