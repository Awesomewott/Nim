using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieces : MonoBehaviour
{
    public GameObject[] row1;
    public GameObject[] row2;
    public GameObject[] row3;


    // Update is called once per frame
    void Update()
    {
        RemovePiece();
    }

    public void RemovePiece()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(row1[0]);
        }
    }
}
