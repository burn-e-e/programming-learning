using System;					
public class Chess_board
{
	public static void Main()
	{
		int[ , ] board = new int[8 , 8];
		for(int i=0; i<8; i++){
			for(int j=0; j<8; j++){
				if((i+j)%2 == 0)
				Console.Write(0 +" ");
			else
				Console.Write(1+" ");
			}
			Console.WriteLine();
		}
	}
}
