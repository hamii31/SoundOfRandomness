namespace numbersToNotes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = new List<int>();

			int n = 150;

			Random rng = new Random();

			for (int i = 0; i < n; i++)
			{
				nums.Add(rng.Next(1, 7));
			}

			List<string> notes = new List<string>();

			foreach (var item in nums)
			{
				switch (item)
				{
					case 1:
						notes.Add("1");
						break;
					case 2:
						notes.Add("2");
						break;
					case 3:
						notes.Add("3");
						break;
					case 4:
						notes.Add("4");
						break;
					case 5:
						notes.Add("5");
						break;
					case 6:
						notes.Add("6");
						break;
					case 7:
						notes.Add("7");
						break;
				}
			}

			Console.WriteLine(string.Join(", ", notes));

			//https://www.autopiano.cn/en/create/post -> post there to play the song
		}
	}
}