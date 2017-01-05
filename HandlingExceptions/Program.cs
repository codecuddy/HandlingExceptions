using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"D:\Coding\DotNet\Projects\HandlingExceptions\Example.txt");
                Console.WriteLine(content);
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the file is named correctly");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);

            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();
        }
    }
}
