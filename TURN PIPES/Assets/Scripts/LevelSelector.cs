using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
