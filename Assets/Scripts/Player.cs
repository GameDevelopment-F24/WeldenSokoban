using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] Walls;
    private GameObject[] Boxes;

    private bool ReadyToMove;
    void Start()
    {
        UpdateReferences();
        ReadyToMove = true;

    }
    public void UpdateReferences()
    {
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
    }
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveInput.Normalize();

        if(moveInput.sqrMagnitude > 0.5)
        {
            if(ReadyToMove)
            {
                ReadyToMove = false;
                Move(moveInput);
            }
        }else{
            ReadyToMove = true;
        }

    }

    public bool Move(Vector2 direction)
    {
        if(Mathf.Abs(direction.x) < 0.5)
        {
            direction.x = 0;
        } else {
            direction.y = 0;
        }
        direction.Normalize();

        if(Blocked(transform.position, direction))
        {
            return false;
        }else{
            transform.Translate(direction);
            return true;
        }
    }
    // public void SetPlayerPosition(Vector2 position)
    // {
    //     transform.position = new Vector3(position.x, position.y, 0);
    // }

    public bool Blocked(Vector3 position, Vector2 direction)
    {

        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach(GameObject wall in Walls)
        {
            if(wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }
        }
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach(GameObject box in Boxes)
        {
            if(box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                Box b = box.GetComponent<Box>();
                if(b && b.Move(direction))
                {
                    return false;
                }else{
                    return true;
                }
            }
        }
        return false;
    }
}
