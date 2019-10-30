using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiceMenu
{
    class Results
    {
        private int _result;
        public int _playerCount{get;}
        public int _diceCount;
        private const int diceMin = 1;
        private const int diceMax = 6;
        private List<int> resultSum = new List<int>();
        private List<int> resultSumList = new List<int>();
        private List<int> testDraw = new List<int>();
        private List<int> deuceList = new List<int>();
        Random random = new Random();

        public Results(int playerCount, int diceCount)
        {
            _playerCount = playerCount;
            _diceCount = diceCount;
        }

        public void Render()
        {
            bool testResults = false;

            do
            {
                Console.Clear();

                for (int i = 0; i < _playerCount; i++)
                {
                    Console.Write($"{i + 1} Player ");
                    for (int j = 0; j < _diceCount; j++)
                    {
                        resultSum.Add(_result = random.Next(diceMin, diceMax));
                        Console.Write(_result + " ");
                    }

                    Console.Write(": " + resultSum.Sum());
                    resultSumList.Add(resultSum.Sum());
                    testDraw.Add(resultSum.Sum());
                    resultSum.Clear();
                    Console.WriteLine();
                }

                int winner = resultSumList.Max();
                testResults = TestResults(winner, testDraw);

                if(testResults == true)
                {
                    Console.WriteLine("It's a deuce!");
                    resultSumList.Clear();
                    //Norejau padaryt, kad tik daugiausiai ismete permestu..
                    //Nelabai spejau
                }

                Console.ReadKey();
                
            } while (testResults);

            Console.SetCursorPosition(14 + (_diceCount + _diceCount), resultSumList.IndexOf(resultSumList.Max()));
            Console.Write("Winner!!!");
            Console.ReadKey();
            Console.Clear();
        }

        private bool TestResults(int winner, List<int> testDraw)
        {
            testDraw.RemoveAt(testDraw.IndexOf(testDraw.Max()));

            for (int i = 0; i < testDraw.Count; i++)
            {
                if (winner == testDraw[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
