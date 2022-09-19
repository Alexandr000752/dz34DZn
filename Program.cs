Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int[] massiv = new int[numberA];

massiv1(massiv);
Print(massiv);


void massiv1(int[] massiv)
{
for(int i = 0; i < massiv.Length; i++)
{
	massiv[i] = new Random().Next(100,1000);
}
}


void Print(int[] massiv)
{
	for(int i = 0; i < massiv.Length; i++)
	{
    
		if(massiv[i]%2 == 0)
		{
		
	    	Console.Write(massiv[i] + ", ");
	    	
		}
	

	}
}
