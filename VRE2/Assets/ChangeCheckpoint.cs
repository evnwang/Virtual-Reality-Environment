using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject checkpoint;
    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player"){
            Destroy(checkpoint);
        }
        //Destroy(gameObject);
    }
}