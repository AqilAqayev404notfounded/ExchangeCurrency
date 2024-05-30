namespace currency
{
    internal class Program
    {
        static void Main(string[] args)
        {



            double[] currencies = { 0.54, 18.97, 0.59 }; //0-azntoeuro 1-azntotry 2-azntodollar
            string[] currenciesTypes = { "Euro", "Tl", "Dollar" };

            int button;
            Console.WriteLine("1 = butun valyutalari gostermek");
            Console.WriteLine("2 = xususi valyutani gostermek");
            Console.WriteLine("3 = Exchage etmek");
            Console.WriteLine("-1 = Exit");

            while (true)
            {


                Console.WriteLine("commandi daxil et");

                button = int.Parse(Console.ReadLine());
                if (button == 1) 
                {
                    int count = 0;
                    while (true)
                    {
                        Console.WriteLine($"1 AZN = {currencies[count] }  {currenciesTypes[count]}");

                        count++;
                        if (count == 3)
                            break;



                    }


                }else if (button == 2)
                {
                    string currencyCode;
                    Console.WriteLine("valyutani adini daxil edin");
                    currencyCode = Console.ReadLine();
                    bool k=false;
                    int i = 0;
                    for ( i = 0; i < currencies.Length; i++)
                    {
                        if(currencyCode == currenciesTypes[i])
                        {
                            k = true;
                            break;
                        }
                    }
                    if(k)
                    {
                        Console.WriteLine(currencies[i]+"-"+ currenciesTypes[i]);
                    }
                    else
                    {
                        Console.WriteLine("Duzgun daxil edin");
                    }

                    //if (currencyCode == "Euro")
                    //{
                    //    Console.WriteLine($"1 AZN = {currencies[0]}{currenciesTypes[0]}");
                    //} 
                    //else if(currencyCode == "Dollar")
                    //{
                    //    Console.WriteLine($"1 AZN = {currencies[2]}{currenciesTypes[2]}");

                    //}else if(currencyCode == "Tl")
                    //{
                    //    Console.WriteLine($"1 AZN = {currencies[1]}{currenciesTypes[1]}");

                    //}
                    //else 
                    //{
                    //    Console.WriteLine("Duzgun daxil edin");
                    //}

                }

                if (button == 3) 
                {

                    Console.WriteLine("MEBLEGI GIRIN:");
                    double userEntered = 0;

                    while (true)
                    {
                        userEntered = Convert.ToDouble(Console.ReadLine());
                        if (userEntered > 0)
                        {

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Duzgun mebleg qeyd edin !!!");

                        }

                    }

                    Console.WriteLine("Valyuta novunu secin:  ");

                    int index = 0;

                    while (index < currenciesTypes.Length)
                    {
                        Console.WriteLine($"{index + 1}.{currenciesTypes[index]}");
                        index++;
                    }

                    int select = 0;
                    while (true)
                    {
                        select = Convert.ToInt32(Console.ReadLine());
                        if (select > 0 && select <= currenciesTypes.Length)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("duzgun secim edin !!!");
                        }
                    }

                    double sum = 0;


                    sum = userEntered * currencies[select - 1];
                    Console.WriteLine($"valyuta cevrilmesi : {sum} {currenciesTypes[select - 1]} ");


                    Console.WriteLine("Yeni valyuta girmek istiyirsiz?   davam etmek istiyirsizse Y/Yes ve yaxud inkar etmek istiyirsizse Exit daxil edin");


                    while (true)
                    {

                        string userWrite = Console.ReadLine();
                        if (userWrite == "Exit")
                        {
                            //break based loop control
                            return;
                        }
                        else if (userWrite != "Yes" && userWrite != "Y")
                        {
                            Console.WriteLine("Duzgun Daxil et");
                        }
                        else
                        {
                            break;
                        }


                    }
                

                

                }
                if (button ==-1)
                {
                    break;



                }




            }



        }
    }
}
