class Task2{

   public Task2(){
                        int digit1= MainClass.readInteger("Введите первое число");
                        int digit2= MainClass.readInteger("Введите второе число");
                
                int min=0;
                int max=0;
            if(digit1>digit2){min=digit2;max=digit1;}else{min=digit1;max=digit2;}


            Console.WriteLine(" max ="+max+" min = "+min);
    }
} 
