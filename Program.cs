using System;
using System.Text.RegularExpressions;

class MainClass 
{


     public static void Main() {

            Task2 task2=new Task2();
             Task4 task4=new Task4();
              Task6 task6=new Task6();
               Task8 task8=new Task8();


 }

 public static int readInteger(String msg){

Boolean itsOK=false;

while(!itsOK){
       Console.WriteLine(msg);

       try{

      String input= Console.ReadLine();
 String st = Regex.Replace(input, "\\D", "");
 
 
  //  Console.WriteLine("поменяно "+st);
    if(st.Length==0){
        Console.WriteLine("ошибка, введите число.");
      continue; 
    }
    

    int res=int.Parse(st);
     Console.WriteLine("(Введено число "+res+")");
  return res;
    }catch(Exception){ continue;}
}



return 0;
 }

 static void Exception(Exception exception){
             Console.WriteLine(exception);
         Environment.Exit(1);
 }
}