using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKillerObstacle : MonoBehaviour
{
     GameObject levelGroup;

    void Start()
    {
        levelGroup = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().levelGroup;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            Debug.Log("Player is dead");
            levelGroup.transform.position = Vector3.zero;
        }
    }
}
