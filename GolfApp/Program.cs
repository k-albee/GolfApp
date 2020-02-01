using System;

namespace GolfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerOne = new Players();
            PlayerOne.PlayerName = "Kevin Albee";
            PlayerOne.Nickname = "kalbee";
            PlayerOne.EmailAddress = "kalbee@microsoft.com";
            PlayerOne.PlayedGolf(18);
            PlayerOne.ScoredGolf(78);
            PlayerOne.HitFairways(10);
            PlayerOne.HitPutts(28);
            PlayerOne.PlayedGolf(18);
            PlayerOne.ScoredGolf(82);
            PlayerOne.HitFairways(8);
            PlayerOne.HitPutts(34);
            Console.WriteLine($"player: {PlayerOne.PlayerName}, nickname: {PlayerOne.Nickname}, email: {PlayerOne.EmailAddress}, holes: {PlayerOne.Holes}, score: {PlayerOne.Score}, fairways: {PlayerOne.Fairways}, putts: {PlayerOne.Putts}");

            var PlayerTwo = new Players();
            PlayerTwo.PlayerName = "Jeff Rovegno";
            PlayerTwo.Nickname = "jeffrov";
            PlayerTwo.EmailAddress = "jeffrov@microsoft.com";
            PlayerTwo.PlayedGolf(18);
            PlayerTwo.ScoredGolf(83);
            PlayerTwo.HitFairways(6);
            PlayerTwo.HitPutts(32);
            Console.WriteLine($"player: {PlayerTwo.PlayerName}, nickname: {PlayerTwo.Nickname}, email: {PlayerTwo.EmailAddress}, holes: {PlayerTwo.Holes}, score: {PlayerTwo.Score}, fairways: {PlayerTwo.Fairways}, putts: {PlayerTwo.Putts}");
        }
    }
}
