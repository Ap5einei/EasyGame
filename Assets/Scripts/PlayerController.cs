using UnityEngine;
using Zenject;
using UniRx;

public class PlayerController : MonoBehaviour
{
    [Inject] private GameStateManager _gameStateManager;
    Rigidbody2D rb;
    public float jumpForce = 1000;
    bool inAir = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _gameStateManager.IsGameOver
            .Where(isOver => isOver)
            .Subscribe(_ => OnGameOver())
            .AddTo(this);
        _gameStateManager.IsReset
            .Where(isReset => isReset)
            .Subscribe(_ => OnReset())
            .AddTo(this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !inAir)
        {
            rb.AddForceAtPosition(Vector2.up * jumpForce, transform.position);
            inAir = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        inAir = true;
    }

    void OnGameOver()
    {
        // Voit lis‰t‰ peli p‰‰ttyy -logiikkaa t‰h‰n
        Debug.Log("Peli p‰‰ttyi!");
    }

    void OnReset()
    {
        // Voit lis‰t‰ reset-logiikkaa t‰h‰n
        Debug.Log("Peli resetoidaan!");
    }
}
