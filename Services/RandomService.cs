namespace ProvaPub.Services
{
	public class RandomService
	{
		private readonly Random _random;
		int seed;
		public RandomService()
		{
			_random = new Random(Guid.NewGuid().GetHashCode());
		}
		public int GetRandom()
		{
			return _random.Next(100);
		}
	}
}
