using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject win;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == win) 
        {
            Debug.Log("YOU WIN");
        }
    }
}
