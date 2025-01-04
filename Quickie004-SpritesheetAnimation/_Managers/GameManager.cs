namespace Quickie004;

public class GameManager
{
    //private Coin _coin;
    private Pigeon1 _pigeon1;
    private Hero _hero;

    public void Init()
    {
        //_coin = new(new(300, 300));
        _pigeon1 = new(new(300, 300));
        _hero = new();
    }

    public void Update()
    {
        InputManager.Update();
        //_coin.Update();
        _pigeon1.Update();
        _hero.Update();
    }

    public void Draw()
    {
        //_coin.Draw();
        _pigeon1.Draw();
        _hero.Draw();
    }
}
