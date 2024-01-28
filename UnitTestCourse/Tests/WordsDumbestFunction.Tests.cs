using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse.Tests
{
    public static class WordsDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
			try
			{
				//Arrange - Go get your variables, whatever you need, you classes, go get functions
				int num = 0;
				WordsDumbestFunction wordsDumbestFunction = new WordsDumbestFunction();

				//Act - Execute this function
				string result = wordsDumbestFunction.ReturnsPikachuIfZero(num);


				//Assert - Whatever ever is returned is it what you want.
				if(result == "PIKACHU")
				{
					Console.WriteLine("PASSED: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
				}
				else
				{
					Console.WriteLine("FAILED: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }

            }
			catch (Exception ex)
			{

				Console.WriteLine(ex);
			}
        }
    }
}
