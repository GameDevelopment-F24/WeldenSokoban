using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] Boxes;
    private GameObject[] Goals;
    public int currentLevel = 1;

 private char[][] level1 = new char[][]
    {
        new char[] {'#','#','#','#','#','#','#','#','.','.'},
        new char[] {'#','X','.','.','.','.','.','#','#','.'},
        new char[] {'#','.','.','.','.','.','.','.','#','#'},
        new char[] {'#','.','.','.','.','.','.','.','.','#'},
        new char[] {'#','.','.','.','.','.','.','.','.','#'},
        new char[] {'#','.','B','.','.','.','.','.','.','#'},
        new char[] {'#','.','.','.','.','.','.','.','.','#'},
        new char[] {'#','.','.','.','.','.','.','.','.','#'},
        new char[] {'#','#','#','#','#','#','#','#','#','#'}
    };
    private char[][] level2 = new char[][]
    {
        new char[] {'#','#','#','#','#','#','#','#','#'},
        new char[] {'#','.','.','.','.','.','.','.','#'},
        new char[] {'#','.','B','.','.','.','.','.','#'},
        new char[] {'#','.','.','.','.','.','.','.','#'},
        new char[] {'#','.','.','#','#','.','.','.','#'},
        new char[] {'#','.','#','#','.','.','.','.','#'},
        new char[] {'#','.','.','.','.','.','X','.','#'},
        new char[] {'#','.','.','.','.','.','.','.','#'},
        new char[] {'#','#','#','#','#','#','#','#','#'}
    };
    private char[][] level3 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', ' ', ' ', '#', ' ', 'X', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', '#', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', 'B', ' ', ' ', '#', ' ', 'X', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private char[][] level4 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', 'B', ' ', '#', ' ', 'X', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', ' ', '#', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private char[][] level5 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', 'X', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', 'X', ' ', ' ', ' ', ' ', '#', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };
    private char[][] level6 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', 'B', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', '#', '#', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
        new char[] {'#', ' ', 'X', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private char[][] level7 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', 'B', ' ', '#', ' ', ' ', ' ', ' ', 'X', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', 'X', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', '#', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', '#', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private int xOffset = -8;
    private int yOffset = -5;

    public GameObject wallPrefab;
    public GameObject goalPrefab;
    public GameObject boxPrefab;

    void PlaceWall(Vector2 position)
    {
        Instantiate(wallPrefab, position, Quaternion.identity);
    }
    void PlaceGoal(Vector2 position)
    {
        Instantiate(goalPrefab, position, Quaternion.identity);
    }
    void PlaceBox(Vector2 position)
    {
        Instantiate(boxPrefab, position, Quaternion.identity);
    }

    public void BuildLevel(char[][] level){
        int rowNum = xOffset;
        int colNum = yOffset;
        foreach (var i in level)
        {
            colNum++;
            foreach (var j in i)
            {
                rowNum++;
                if (j == '#')
                {
                    PlaceWall(new Vector2(rowNum, colNum));
                }
                if (j == 'X')
                {
                    PlaceGoal(new Vector2(rowNum, colNum));
                }
                if (j == 'B')
                {
                    PlaceBox(new Vector2(rowNum, colNum));
                }
            }
            rowNum = xOffset;
            
        }
    }
    public void ClearLevel(){
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach(GameObject wall in walls)
        {
            Destroy(wall);
        }
        GameObject[] goals = GameObject.FindGameObjectsWithTag("Goal");
        foreach(GameObject goal in goals)
        {
            Destroy(goal);
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach(GameObject box in boxes)
        {
            Destroy(box);
        }
    }


    void Start()
    {
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        SetLevel(currentLevel);
    }

    void Update()
    {
        if(allGoalsHaveBoxes())
        {
            Debug.Log("You Win!");
            ClearLevel();
            currentLevel++;
            SetLevel(currentLevel);
        }
    }

    public bool allGoalsHaveBoxes(){
        bool hasBox = false;
        foreach(GameObject goal in Goals)
        {
            
            foreach(GameObject box in Boxes)
            {
                if(goal.transform.position.x == box.transform.position.x && goal.transform.position.y == box.transform.position.y)
                {
                    hasBox = true;
                }
            }
        }
        return hasBox;
    }

    public void SetLevel(int level){
        currentLevel = level;
        ClearLevel();
        if(currentLevel == 1)
        {
            BuildLevel(level1);
        }
        if(currentLevel == 2)
        {
            BuildLevel(level2);
        }
        if(currentLevel == 3)
        {
            BuildLevel(level3);
        }
        if(currentLevel == 4)
        {
            BuildLevel(level4);
        }
        if(currentLevel == 5)
        {
            BuildLevel(level5);
        }
        if(currentLevel == 6)
        {
            BuildLevel(level6);
        }
        if(currentLevel == 7)
        {
            BuildLevel(level7);
        }
    }
}
