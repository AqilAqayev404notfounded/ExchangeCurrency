namespace currency
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //double [0]manat_to_dollar = 0.59;

            //double [1]manat_to_euro = 0.54;
            //double [2]manat_to_tl = 18.97 ;
                //double AZN_TO_EUR = 0.54;
                //double AZN_TO_TRY = 18.97;
                //double AZN_TO_DOLLAR = 0.59;

            double[] currencies = { 0.54 , 18.97 , 0.59 }; //0-azntoeuro 1-azntotry 2-azntodollar


            while (true)
            {

                Console.WriteLine("MEBLEGI GIRIN:");
                double userEntered = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Valyuta novunu secin: 1. USD (ABD Dollar)  2. EUR (Euro)  3. TRY (Türk Lirasi) 'secmek ucun  1 , 2 , 3 dem istifade edin' ");
                int select = Convert.ToInt32(Console.ReadLine());


                double sum = 0;

                if (select == 1)
                {
                    Console.WriteLine(sum = userEntered * currencies[2]);

                }
                else if (select == 2)
                {
                    Console.WriteLine(sum = userEntered * currencies[0]);

                }
                else if (select == 3)
                {
                    Console.WriteLine(sum = userEntered * currencies[1]);

                }
                else
                {
                    Console.WriteLine("Duzgun select edin");
                }


                Console.WriteLine($"valyuta cevrilmesi : {sum}");

                Console.WriteLine("yeni valyuta firmek istiyirsiz?   davam etmek istiyirsizse Y/Yes ve yaxud inkar etmek istiyirsizse N/No daxil edin");

                string yesNo = Console.ReadLine();

                if (yesNo =="N"||  yesNo =="No") 
                {
                    break;
                }
                if (yesNo == "Yes" || yesNo == "Y")
                {

                }
                if(yesNo !="Yes"||yesNo !="Y"||yesNo != "N"||yesNo != "No")
                {
                    Console.WriteLine("Duzgun cavab daxil et");
                } 


            }

            

        }
    }
}
