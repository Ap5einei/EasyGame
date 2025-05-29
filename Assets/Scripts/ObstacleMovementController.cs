using UnityEngine;
using Zenject;

public class ObstacleMovementController : MonoBehaviour
{
    [Inject] private GameManager _gameManager;
    public float movementSpeed = 4;

    void Update()
    {
        transform.position += new Vector3(-_gameManager.movementSpeed * Time.deltaTime, 0, 0);
    }
}
