using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float movementSpeed =7;
    public GameObject levelGroup;
    public Vector3 lastCheckpoint = new Vector3(0,0,0);
    public void ResetPositions()
    {
        levelGroup.transform.position = new Vector3(lastCheckpoint.x, 0, 0);
    }

    public void UpdateCheckpoint(Vector3 newCheckpoint)
    {
        lastCheckpoint = newCheckpoint; 
    }

}
