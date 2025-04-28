using System;

class MainClass {
  public static void Main (string[] args) {
		
		var arr = new int[] { 1, 2,3 };
		var data = 5;

		BigDataOperation(arr, ref data);

		Console.WriteLine(arr[0]);

		Console.ReadKey();

  }

	static void BigDataOperation(int[] array, ref int data)
	{
		data = 4;
		array[0] = 4;
	}

	

}