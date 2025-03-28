using Lessons.Memento;

var hero = new Hero(3, 10);
var gameHistory = new GameHistory();

hero.Shoot();
hero.Shoot();
hero.Shoot();

var history = hero.SaveState();
gameHistory.Add(history);

hero.Shoot();
hero.Shoot();
hero.Shoot();

history = gameHistory.Pop();
hero.RestoreState(history);

hero.Shoot();
hero.Shoot();
hero.Shoot();