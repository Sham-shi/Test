
namespace Lessons.Memento;

public class Hero
{
    public int _lives;
    public int _ammunition;

    public Hero(int lives, int ammunition)
    {
        _lives = lives;
        _ammunition = ammunition;
    }

    public void Shoot()
    {
        _ammunition--;

        Console.WriteLine($"кол-во патронов {_ammunition}");
    }

    public HeroMemento SaveState()
    {
        return new HeroMemento(_lives, _ammunition);
    }

    public void RestoreState(HeroMemento heroMemento)
    {
        _lives = heroMemento.Lives;
        _ammunition = heroMemento.Ammunition;
    }
}
