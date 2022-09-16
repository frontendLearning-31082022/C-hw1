class Task8{

   public Task8(){

            int number=MainClass.readInteger("Введите число");

            for (int i = 1; i < number+1; i++)
            {
                if(i%2==0)Console.WriteLine("Число "+i+" четное");
            }
           

    }
} 