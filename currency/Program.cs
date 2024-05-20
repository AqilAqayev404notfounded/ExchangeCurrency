namespace currency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            double[] currencies = { 0.54 , 18.97 , 0.59 }; //0-azntoeuro 1-azntotry 2-azntodollar
            string[] currenciesTypes = { "Euro", "Tl", "Dollar" };

            while (true)
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

                Console.WriteLine("Valyuta novunu secin: 1. USD (ABD Dollar)  2. EUR (Euro)  3. TRY (Türk Lirasi) 'secmek ucun  1 , 2 , 3 dem istifade edin' ");

                int select = 0;
                while (true)
                {
                     select = Convert.ToInt32(Console.ReadLine());
                    if (select > 0 && select<=3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("duzgun secim edin !!!");
                    }
                }

                double sum = 0;

                if (select == 1)
                {
                    sum = userEntered * currencies[2];

                    Console.WriteLine($"valyuta cevrilmesi : {sum} {currenciesTypes[2]} ");
                }
                else if (select == 2)
                {
                    sum = userEntered * currencies[0];

                    Console.WriteLine($"valyuta cevrilmesi : {sum} {currenciesTypes[0]} ");
                }
                else if (select == 3)
                {
                    sum = userEntered * currencies[1];
                    Console.WriteLine($"valyuta cevrilmesi : {sum} {currenciesTypes[1]} ");
                }
                


                

                Console.WriteLine("Yeni valyuta girmek istiyirsiz?   davam etmek istiyirsizse Y/Yes ve yaxud inkar etmek istiyirsizse Exit daxil edin");

                //string yesNo = Console.ReadLine();

                //if (yesNo =="N"||  yesNo =="No") 
                //{
                //    break;
                //}
                //if (yesNo == "Yes" || yesNo == "Y")
                //{

                //}
                string loopTerminationResult = Console.ReadLine();
                if (loopTerminationResult == "Exit")
                {
                        //break based loop control
                 break;
                }
                else if (loopTerminationResult == "Yes" || loopTerminationResult == "Y")
                {

                }
                   
              
               
               


            }

            

        }
    }
}
