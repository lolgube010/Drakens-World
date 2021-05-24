using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    Transform tr;
    public Transform playerTr; 
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        tr.position = new Vector3(0, playerTr.position.y , -10); // gör så att kameran följer spelaren på y axeln -Bo
    }
}
