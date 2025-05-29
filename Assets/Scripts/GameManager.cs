using UnityEngine;
using Zenject;
using UniRx;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float movementSpeed = 7;
    public GameObject levelGroup;
    public Vector3 lastCheckpoint = new Vector3(0, 0, 0);
    public Text attemptText;
    private int numeberOfAttempts;

    [Inject] private GameStateManager _gameStateManager;

    public void ResetPositions()
    {
        levelGroup.transform.position = new Vector3(lastCheckpoint.x, 0, 0);
        _gameStateManager.ResetGame();
        numeberOfAttempts++;
        attemptText.text = "Attempts: " + numeberOfAttempts;
    }

    public void UpdateCheckpoint(Vector3 newCheckpoint)
    {
        lastCheckpoint = newCheckpoint;
    }
}
