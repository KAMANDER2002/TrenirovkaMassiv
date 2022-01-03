using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {

            ReshenieZadachi reshenie = new ReshenieZadachi();
            Console.WriteLine("Все накладные: " + Environment.NewLine + reshenie.OutPut());
            Console.WriteLine(Environment.NewLine + "Введите сумму накладных которые надо вывести" + Environment.NewLine);
            int summ = Convert.ToInt32(Console.ReadLine());
            reshenie.OutPutSumm(summ);
            Console.WriteLine(reshenie.ResponceSumm);
             Console.WriteLine(Environment.NewLine + "Введите дату в формате dd/mm/yyyy" + Environment.NewLine);
             string data = Console.ReadLine();
             reshenie.DeleteNakladnaya(data);
             Console.WriteLine(Environment.NewLine + "Накладные с данной датой удалены" + Environment.NewLine + reshenie.Responce);
        }
    }
}
