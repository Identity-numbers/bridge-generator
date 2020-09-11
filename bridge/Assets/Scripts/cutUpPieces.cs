using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutUpPieces : MonoBehaviour
{
    //start number to cut up
    public int startNumber;

    List<int> cutUpP = new List<int>();

    //return a random piece from collection
    public int returnRandomPiece()
    {
        int r = Random.Range (0, cutUpP.Count);
        return r;
    }

    public void cutItUp()
    {
        /*
        if (startNumber == null)
        {
            Debug.Log("startNumber not set");
        }
        */

        int tempNmbr = startNumber;

        while (tempNmbr >0)
        {
            cutUpP.Add(tempNmbr);
            tempNmbr /= 10; 
        }
    }
}
