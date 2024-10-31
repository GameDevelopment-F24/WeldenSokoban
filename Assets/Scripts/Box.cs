using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Box : MonoBehaviour
{
    private GameObject[] Walls;
    private GameObject[] Boxes;
    private GameObject[] Goals;

    public bool inPlace;
    void Start()
    {
        UpdateReferences();

    }
    public void UpdateReferences()
    {
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
    }

    void Update()
    {
        ArrivedOnGoal();
        
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
                return true;
            }
        }
        return false;
    }
    public void ArrivedOnGoal()
    {
        SpriteRenderer boxColor = GetComponent<SpriteRenderer>();
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        foreach(GameObject goal in Goals)
        {
            if(transform.position.x == goal.transform.position.x && transform.position.y == goal.transform.position.y)
            {
                inPlace = true;
                boxColor.color = Color.green;
                return;
            }
        }
        boxColor.color = Color.white;
        inPlace = false;
    }
}
