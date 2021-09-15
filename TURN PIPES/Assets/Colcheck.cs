using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colcheck : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BAD PIPE"))
        {
            Debug.Log("HIT");        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("BAD PIPE"))
        {
            Debug.Log("MISS");
        }
    }
}
