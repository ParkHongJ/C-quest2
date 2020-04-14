using System;


public class Test
{
    public static void Main()
    {
        object obj = 1230;
        int b = 0;
        if (obj.GetType().Name == "Int32")
        {
            b = 1;
        }
        else if(obj.GetType().Name == "Single")
        {
            b = 2;
        }
        switch(b)
        {
            case 1:
                Console.WriteLine("정수입니다");
                break;
            case 2:
                Console.WriteLine("실수입니다.");
                break;
            default:
                break;

        }
        //obj.GetType()
    }
}