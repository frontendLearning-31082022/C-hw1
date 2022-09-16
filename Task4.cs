using System.Collections;
class Task4{

   public Task4(){

            ArrayList arlist = new ArrayList(); 
            arlist.Add(MainClass.readInteger("Введите число"));
            arlist.Add(MainClass.readInteger("Введите число"));
            arlist.Add(MainClass.readInteger("Введите число"));

            int maxVal=(int)arlist[0];

          foreach(object o in arlist)
{
   int myObject = (int)o;  
   if(myObject>maxVal)maxVal=myObject;
}

Console.Write("Максимальное число"+ maxVal);

           
    }
} 
