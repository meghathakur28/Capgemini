using System;
using Event_DrivenLotteryTicketSystem;

class Program
{
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            var lottery = new Lottery(new CustomEventArgs { Quantity = 10 });
            var winners = lottery.LotteryWinners();
            var index = 1;
            foreach (var winner in winners)
                Console.WriteLine($"{index++}.{winner}");

        }
}