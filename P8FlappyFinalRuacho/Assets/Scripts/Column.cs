using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
  
  