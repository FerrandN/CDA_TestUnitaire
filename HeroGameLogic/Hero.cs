namespace HeroGameLogic
{
    public class Hero
    {
        public int lifePoint { get; private set; }
        public int points { get; private set; }

        public Hero(int _lifePoint)
        {
            lifePoint = _lifePoint;
        }

        public void WinBattle()
        {
            points++;
        }

        public void LostBattle(int nb)
        {
            lifePoint -= nb;
        }
    }
}