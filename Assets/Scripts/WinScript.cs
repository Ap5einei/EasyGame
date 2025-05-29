using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
   public GameObject winPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            winPanel.SetActive(true);
            StartCoroutine(LoadMainMenuAfterDelay());
        }
    }

    IEnumerator LoadMainMenuAfterDelay()
    {
        yield return new WaitForSecondsRealtime(5f);
        SceneManager.LoadScene("MainMenu");
    }
}
