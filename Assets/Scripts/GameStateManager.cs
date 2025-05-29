using UniRx;

public class GameStateManager
{
    public ReactiveProperty<bool> IsGameOver = new ReactiveProperty<bool>(false);
    public ReactiveProperty<bool> IsReset = new ReactiveProperty<bool>(false);

    public void GameOver()
    {
        IsGameOver.Value = true;
    }

    public void ResetGame()
    {
        IsReset.Value = true;
        IsGameOver.Value = false;
        IsReset.Value = false; // Palauta heti false, jotta tapahtuma ei j‰‰ p‰‰lle
    }
}
