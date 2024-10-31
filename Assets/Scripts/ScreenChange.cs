using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Sokoban");
    }
    public void EndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }

  
}
