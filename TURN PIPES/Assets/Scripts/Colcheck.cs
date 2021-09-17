using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colcheck : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BAD PIPE"))
        {
            Debug.Log("HIT");
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
        
    }
    

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("BAD PIPE"))
        {
            Debug.Log("MISS");
        }
    }
}
