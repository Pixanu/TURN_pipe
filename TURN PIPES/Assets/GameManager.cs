using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PipeHolder;
    public GameObject[] Pipes;
    

    [SerializeField]
    int correctedPipes = 0;



    public int totalPipes = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalPipes = PipeHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i=0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipeHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctedPipes += 1;

        Debug.Log("correct Move");
        if(correctedPipes == totalPipes)
        {

            Debug.Log("Victory!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }


    }

    public void wrongMove()
    {
        correctedPipes -= 1;
    }

    
}
