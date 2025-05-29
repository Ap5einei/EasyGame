using UnityEngine;
using Zenject;
using UniRx;

public class PlayerKillerObstacle : MonoBehaviour
{
    [Inject] private GameManager _gameManager;
    [Inject] private GameStateManager _gameStateManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player is dead");
            _gameStateManager.GameOver();
            _gameManager.ResetPositions();
        }
    }
}
