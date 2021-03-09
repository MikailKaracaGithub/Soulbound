using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    public MapGenerator map;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        map.GenerateMap();
    }
}
