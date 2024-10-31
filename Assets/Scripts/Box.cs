using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Box : MonoBehaviour
{
    private GameObject[] Walls;
    private GameObject[] Boxes;
    private GameObject[] Goals;
    void Start()
    {
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        Goals = GameObject.FindGameObjectsWithTag("Goal");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Move(Vector2 direction)
    {
        if(BoxBlocked(transform.position, direction))
        {
            return false;
        }else{
            transform.Translate(direction);
            return true;
        }
    }
    public bool BoxBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        foreach(GameObject wall in Walls)
        {
            if(wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }
        }
        foreach(GameObject box in Boxes)
        {
            if(box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                return true;
            }
        }
        return false;
    }
    public bool isOnGoal{
        get{
            foreach(GameObject goal in Goals)
            {
                if(goal.transform.position.x == transform.position.x && goal.transform.position.y == transform.position.y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
