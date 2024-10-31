using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] Boxes;
    private GameObject[] Goals;
    private GameObject[] Walls;
    public int currentLevel;

    private char[][] level1 = new char[][]
    {
        new char[] {'#','#','#','#','#','#','#','#',' ',' '},
        new char[] {'#','X',' ',' ',' ',' ',' ','#','#',' '},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ','#','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#',' ',' ',' ','P',' ',' ',' ',' ','#'},
        new char[] {'#',' ','B',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#','#','#','#','#','#','#','#','#','#'}
    };
    private char[][] level2 = new char[][]
    {
        new char[] {'#','#','#','#','#','#','#','#','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#',' ','B',' ',' ',' ','P',' ','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ','#'},
        new char[] {'#',' ',' ','#','#',' ',' ',' ','#'},
        new char[] {'#',' ','#','#',' ',' ',' ',' ','#'},
        new char[] {'#',' ',' ',' ',' ',' ','X',' ','#'},
        new char[] {'#',' ',' ',' ',' ',' ',' ',' ','#'},
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
        new char[] {'#', ' ', 'P', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private char[][] level4 = new char[][]
    {
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'P', ' ', '#', ' ', ' ', ' ', 'B', ' ', '#', ' ', 'X', '#'},
        new char[] {'#', ' ', ' ', ' ', '#', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', 'B', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', 'B', ' ', '#'},
        new char[] {'#', ' ', ' ', '#', ' ', ' ', ' ', '#', '#', '#', ' ', 'X', ' ', '#'},
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
        new char[] {'#', ' ', ' ', ' ', '#', ' ', 'P', ' ', ' ', ' ', '#', ' ', ' ', '#'},
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
        new char[] {'#', ' ', ' ', ' ', 'P', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', '#'},
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
        new char[] {'#', ' ', 'B', ' ', '#', ' ', 'X', ' ', ' ', 'P', ' ', ' ', ' ', '#'},
        new char[] {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        new char[] {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    private int xOffset = -8;
    private int yOffset = -5;

    public GameObject wallPrefab;
    public GameObject goalPrefab;
    public GameObject boxPrefab;
    public GameObject playerPrefab;

    void PlaceWall(Vector2 position)
    {
        Debug.Log("Placing wall at position: " + position);
        Instantiate(wallPrefab, position, Quaternion.identity);
    }
    void PlaceGoal(Vector2 position)
    {
        Debug.Log("Placing goal at position: " + position);
        Instantiate(goalPrefab, position, Quaternion.identity);
    }
    void PlaceBox(Vector2 position)
    {
        Debug.Log("Placing box at position: " + position);
        Instantiate(boxPrefab, position, Quaternion.identity);
    }
    void PlacePlayer(Vector2 position)
    {
        Debug.Log("Placing player at position: " + position);
        Instantiate(playerPrefab, position, Quaternion.identity);
    }

    public void BuildLevel(char[][] level){
        Debug.Log("Building level");
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
                if (j == 'P')
                {
                    PlacePlayer(new Vector2(rowNum, colNum));
                }
            }
            rowNum = xOffset;
            
        }
    }
    public void ClearLevel(){
        Debug.Log("Clearing level");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var box in Boxes)
        {
            Destroy(box);
        }
        foreach (var goal in Goals)
        {
            Destroy(goal);
        }
        foreach (var wall in Walls)
        {
            Destroy(wall);
        }
        Destroy(GameObject.FindWithTag("Player"));
    }

    void Start()
    {
        Debug.Log("Game started");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        SetLevel(currentLevel);
    }

    void Update()
    {
        if (IsLevelComplete())
        {
            Debug.Log("You Win!");
            currentLevel++;
            SetLevel(currentLevel);
        }
    }

   private bool IsLevelComplete(){
        Debug.Log("Checking if level is complete");
        Box[] boxes = FindObjectsOfType<Box>();
        foreach (var box in boxes){
            if (!box.inPlace){
                return false;
            }
        }
        return true;
    }

    public void SetLevel(int level)
    {
        Debug.Log("Setting level to: " + level);
        currentLevel = level;
        ClearLevel();
        
        if (currentLevel == 1) BuildLevel(level1);
        else if (currentLevel == 2) BuildLevel(level2);
        else if (currentLevel == 3) BuildLevel(level3);
        else if (currentLevel == 4) BuildLevel(level4);
        else if (currentLevel == 5) BuildLevel(level5);
        else if (currentLevel == 6) BuildLevel(level6);
        else if (currentLevel == 7) BuildLevel(level7);
        UpdateReferences();
    }

    private void UpdateReferences()
    {
        Debug.Log("Updating references");
        Boxes = GameObject.FindGameObjectsWithTag("Box");
        Goals = GameObject.FindGameObjectsWithTag("Goal");
        Walls = GameObject.FindGameObjectsWithTag("Wall");
        
    }
    public void RestartLevel()
    {
        Debug.Log("Restarting level");
        SetLevel(currentLevel);
    }
}
