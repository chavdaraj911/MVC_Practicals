using System;

namespace string
{
    class Program
{
   
	{
		static int ASCII_SIZE = 256;

		static char getCharOccurence(String str)
		{
			
			int[] count = new int[ASCII_SIZE];

			int len = str.Length;
			for (int i = 0; i < len; i++)
				count[str[i]]++;

			int max = -1; 
			char result = ' '; 

			
			for (int i = 0; i < len; i++)
			{
				if (max < count[str[i]])
				{
					max = count[str[i]];
					result = str[i];
				}
			}

			return result;
		}

		
		public static void Main()
		{
			String str = "sample string";
			Console.Write("Max occurring character is " + getCharOccurence(str));
		}
	}

	// This code is contributed by Sam007

}

