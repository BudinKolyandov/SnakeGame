namespace SnakeGame.GameObjects
{
    class FoodHash : Food
    {
        private const char foodSymbol = '#';
        private const int points = 4;

        public FoodHash(Wall wall)
            : base(wall, foodSymbol, points)
        {
        }
    }
}
