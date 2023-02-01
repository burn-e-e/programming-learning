using System;
					
public class Program
{
	
	public static void Main()
	{
		int[] a = new int[4];
		for(int i=0; i<4; i++){
			a[i] = int.Parse(Console.ReadLine());
		}
        if(((a[0]+a[1])%2==0 && (a[3]+a[4])%2==0) || ((a[0]+a[1])%2==1 && (a[3]+a[4])%2==1))
        {
			Console.WriteLine("NO");
		}else{
			Console.WriteLine("YES");
		}
	}
}