using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbercheck
{
    class Program
    {
        public static object Keyboard { get; private set; }

        public static void Clear()
        {
            letters();
        }
        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void letters()
        {

            int PlusOrMinus = 1;

            if (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.A))
            { PlusOrMinus = 2; }

            if (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.D))
            {
                PlusOrMinus = 1;
                
            }

            for (int spacehori = 0; spacehori < 120;)
            {
                while (PlusOrMinus == 1)
                {
                    spacehori++;
                    
                    if (spacehori == 1) { Console.Clear(); Console.WriteLine(" " + "c"); }
                    if (spacehori == 2) { Console.Clear(); Console.WriteLine("  " + "c"); }
                    if (spacehori == 3) { Console.Clear(); Console.WriteLine("   " + "c"); }
                    if (spacehori == 4) { Console.Clear(); Console.WriteLine("    " + "c"); }
                    if (spacehori == 5) { Console.Clear(); Console.WriteLine("     " + "c"); }
                    if (spacehori == 6) { Console.Clear(); Console.WriteLine("      " + "c"); }
                    if (spacehori == 7) { Console.Clear(); Console.WriteLine("       " + "c"); }
                    if (spacehori == 8) { Console.Clear(); Console.WriteLine("        " + "c"); }
                    if (spacehori == 9) { Console.Clear(); Console.WriteLine("         " + "c"); }
                    if (spacehori == 10) { Console.Clear(); Console.WriteLine("         " + "c"); }
                    if (spacehori == 11) { Console.Clear(); Console.WriteLine("          " + "c"); }
                    if (spacehori == 12) { Console.Clear(); Console.WriteLine("           " + "c"); }
                    if (spacehori == 13) { Console.Clear(); Console.WriteLine("            " + "c"); }
                    if (spacehori == 14) { Console.Clear(); Console.WriteLine("             " + "c"); }
                    if (spacehori == 15) { Console.Clear(); Console.WriteLine("              " + "c"); }
                    if (spacehori == 16) { Console.Clear(); Console.WriteLine("               " + "c"); }
                    if (spacehori == 17) { Console.Clear(); Console.WriteLine("                " + "c"); }
                    if (spacehori == 18) { Console.Clear(); Console.WriteLine("                 " + "c"); }
                    if (spacehori == 19) { Console.Clear(); Console.WriteLine("                  " + "c"); }
                    if (spacehori == 20) { Console.Clear(); Console.WriteLine("                   " + "c"); }
                    if (spacehori == 21) { Console.Clear(); Console.WriteLine("                    " + "c"); }
                    if (spacehori == 22) { Console.Clear(); Console.WriteLine("                     " + "c"); }
                    if (spacehori == 23) { Console.Clear(); Console.WriteLine("                      " + "c"); }
                    if (spacehori == 24) { Console.Clear(); Console.WriteLine("                       " + "c"); }
                    if (spacehori == 25) { Console.Clear(); Console.WriteLine("                        " + "c"); }
                    if (spacehori == 26) { Console.Clear(); Console.WriteLine("                         " + "c"); }
                    if (spacehori == 27) { Console.Clear(); Console.WriteLine("                          " + "c"); }
                    if (spacehori == 28) { Console.Clear(); Console.WriteLine("                           " + "c"); }
                    if (spacehori == 29) { Console.Clear(); Console.WriteLine("                            " + "c"); }
                    if (spacehori == 30) { Console.Clear(); Console.WriteLine("                             " + "c"); }
                    if (spacehori == 31) { Console.Clear(); Console.WriteLine("                              " + "c"); }
                    if (spacehori == 32) { Console.Clear(); Console.WriteLine("                               " + "c"); }
                    if (spacehori == 33) { Console.Clear(); Console.WriteLine("                                " + "c"); }
                    if (spacehori == 34) { Console.Clear(); Console.WriteLine("                                 " + "c"); }
                    if (spacehori == 35) { Console.Clear(); Console.WriteLine("                                  " + "c"); }
                    if (spacehori == 36) { Console.Clear(); Console.WriteLine("                                   " + "c"); }
                    if (spacehori == 37) { Console.Clear(); Console.WriteLine("                                    " + "c"); }
                    if (spacehori == 38) { Console.Clear(); Console.WriteLine("                                     " + "c"); }
                    if (spacehori == 39) { Console.Clear(); Console.WriteLine("                                      " + "c"); }
                    if (spacehori == 40) { Console.Clear(); Console.WriteLine("                                       " + "c"); }
                    if (spacehori == 41) { Console.Clear(); Console.WriteLine("                                        " + "c"); }
                    if (spacehori == 42) { Console.Clear(); Console.WriteLine("                                         " + "c"); }
                    if (spacehori == 43) { Console.Clear(); Console.WriteLine("                                          " + "c"); }
                    if (spacehori == 44) { Console.Clear(); Console.WriteLine("                                           " + "c"); }
                    if (spacehori == 45) { Console.Clear(); Console.WriteLine("                                            " + "c"); }
                    if (spacehori == 46) { Console.Clear(); Console.WriteLine("                                             " + "c"); }
                    if (spacehori == 47) { Console.Clear(); Console.WriteLine("                                              " + "c"); }
                    if (spacehori == 48) { Console.Clear(); Console.WriteLine("                                               " + "c"); }
                    if (spacehori == 49) { Console.Clear(); Console.WriteLine("                                                " + "c"); }
                    if (spacehori == 50) { Console.Clear(); Console.WriteLine("                                                 " + "c"); }
                    if (spacehori == 51) { Console.Clear(); Console.WriteLine("                                                  " + "c"); }
                    if (spacehori == 52) { Console.Clear(); Console.WriteLine("                                                   " + "c"); }
                    if (spacehori == 53) { Console.Clear(); Console.WriteLine("                                                    " + "c"); }
                    if (spacehori == 54) { Console.Clear(); Console.WriteLine("                                                     " + "c"); }
                    if (spacehori == 55) { Console.Clear(); Console.WriteLine("                                                      " + "c"); }
                    if (spacehori == 56) { Console.Clear(); Console.WriteLine("                                                       " + "c"); }
                    if (spacehori == 57) { Console.Clear(); Console.WriteLine("                                                        " + "c"); }
                    if (spacehori == 58) { Console.Clear(); Console.WriteLine("                                                         " + "c"); }
                    if (spacehori == 59) { Console.Clear(); Console.WriteLine("                                                          " + "c"); }
                    if (spacehori == 60) { Console.Clear(); Console.WriteLine("                                                           " + "c"); }
                    if (spacehori == 61) { Console.Clear(); Console.WriteLine("                                                            " + "c"); }
                    if (spacehori == 62) { Console.Clear(); Console.WriteLine("                                                             " + "c"); }
                    if (spacehori == 63) { Console.Clear(); Console.WriteLine("                                                              " + "c"); }
                    if (spacehori == 64) { Console.Clear(); Console.WriteLine("                                                               " + "c"); }
                    if (spacehori == 65) { Console.Clear(); Console.WriteLine("                                                                " + "c"); }
                    if (spacehori == 66) { Console.Clear(); Console.WriteLine("                                                                 " + "c"); }
                    if (spacehori == 67) { Console.Clear(); Console.WriteLine("                                                                  " + "c"); }
                    if (spacehori == 68) { Console.Clear(); Console.WriteLine("                                                                   " + "c"); }
                    if (spacehori == 69) { Console.Clear(); Console.WriteLine("                                                                    " + "c"); }
                    if (spacehori == 70) { Console.Clear(); Console.WriteLine("                                                                     " + "c"); }
                    if (spacehori == 71) { Console.Clear(); Console.WriteLine("                                                                      " + "c"); }
                    if (spacehori == 72) { Console.Clear(); Console.WriteLine("                                                                       " + "c"); }
                    if (spacehori == 73) { Console.Clear(); Console.WriteLine("                                                                        " + "c"); }
                    if (spacehori == 74) { Console.Clear(); Console.WriteLine("                                                                         " + "c"); }
                    if (spacehori == 75) { Console.Clear(); Console.WriteLine("                                                                          " + "c"); }
                    if (spacehori == 76) { Console.Clear(); Console.WriteLine("                                                                           " + "c"); }
                    if (spacehori == 77) { Console.Clear(); Console.WriteLine("                                                                            " + "c"); }
                    if (spacehori == 78) { Console.Clear(); Console.WriteLine("                                                                             " + "c"); }
                    if (spacehori == 79) { Console.Clear(); Console.WriteLine("                                                                              " + "c"); }
                    if (spacehori == 80) { Console.Clear(); Console.WriteLine("                                                                               " + "c"); }
                    if (spacehori == 81) { Console.Clear(); Console.WriteLine("                                                                                " + "c"); }
                    if (spacehori == 82) { Console.Clear(); Console.WriteLine("                                                                                 " + "c"); }
                    if (spacehori == 83) { Console.Clear(); Console.WriteLine("                                                                                  " + "c"); }
                    if (spacehori == 84) { Console.Clear(); Console.WriteLine("                                                                                   " + "c"); }
                    if (spacehori == 85) { Console.Clear(); Console.WriteLine("                                                                                    " + "c"); }
                    if (spacehori == 86) { Console.Clear(); Console.WriteLine("                                                                                     " + "c"); }
                    if (spacehori == 87) { Console.Clear(); Console.WriteLine("                                                                                      " + "c"); }
                    if (spacehori == 88) { Console.Clear(); Console.WriteLine("                                                                                       " + "c"); }
                    if (spacehori == 89) { Console.Clear(); Console.WriteLine("                                                                                        " + "c"); }
                    if (spacehori == 90) { Console.Clear(); Console.WriteLine("                                                                                         " + "c"); }
                    if (spacehori == 91) { Console.Clear(); Console.WriteLine("                                                                                          " + "c"); }
                    if (spacehori == 92) { Console.Clear(); Console.WriteLine("                                                                                           " + "c"); }
                    if (spacehori == 93) { Console.Clear(); Console.WriteLine("                                                                                            " + "c"); }
                    if (spacehori == 94) { Console.Clear(); Console.WriteLine("                                                                                             " + "c"); }
                    if (spacehori == 95) { Console.Clear(); Console.WriteLine("                                                                                              " + "c"); }
                    if (spacehori == 96) { Console.Clear(); Console.WriteLine("                                                                                               " + "c"); }
                    if (spacehori == 97) { Console.Clear(); Console.WriteLine("                                                                                                " + "c"); }
                    if (spacehori == 98) { Console.Clear(); Console.WriteLine("                                                                                                 " + "c"); }
                    if (spacehori == 99) { Console.Clear(); Console.WriteLine("                                                                                                  " + "c"); }
                    if (spacehori == 100) { Console.Clear(); Console.WriteLine("                                                                                                   " + "c"); }
                    if (spacehori == 101) { Console.Clear(); Console.WriteLine("                                                                                                    " + "c"); }
                    if (spacehori == 102) { Console.Clear(); Console.WriteLine("                                                                                                     " + "c"); }
                    if (spacehori == 103) { Console.Clear(); Console.WriteLine("                                                                                                      " + "c"); }
                    if (spacehori == 104) { Console.Clear(); Console.WriteLine("                                                                                                       " + "c"); }
                    if (spacehori == 105) { Console.Clear(); Console.WriteLine("                                                                                                        " + "c"); }
                    if (spacehori == 106) { Console.Clear(); Console.WriteLine("                                                                                                         " + "c"); }
                    if (spacehori == 107) { Console.Clear(); Console.WriteLine("                                                                                                          " + "c"); }
                    if (spacehori == 108) { Console.Clear(); Console.WriteLine("                                                                                                           " + "c"); }
                    if (spacehori == 109) { Console.Clear(); Console.WriteLine("                                                                                                            " + "c"); }
                    if (spacehori == 110) { Console.Clear(); Console.WriteLine("                                                                                                             " + "c"); }
                    if (spacehori == 111) { Console.Clear(); Console.WriteLine("                                                                                                              " + "c"); }
                    if (spacehori == 112) { Console.Clear(); Console.WriteLine("                                                                                                               " + "c"); }
                    if (spacehori == 113) { Console.Clear(); Console.WriteLine("                                                                                                                " + "c"); }
                    if (spacehori == 114) { Console.Clear(); Console.WriteLine("                                                                                                                 " + "c"); }
                    if (spacehori == 115) { Console.Clear(); Console.WriteLine("                                                                                                                  " + "c"); }
                    if (spacehori == 116) { Console.Clear(); Console.WriteLine("                                                                                                                   " + "c"); }
                    if (spacehori == 117) { Console.Clear(); Console.WriteLine("                                                                                                                    " + "c"); }
                    if (spacehori == 118) { Console.Clear(); Console.WriteLine("                                                                                                                     " + "c"); }
                    if (spacehori == 119) { Console.Clear(); Console.WriteLine("                                                                                                                      " + "c"); }
                    if (spacehori == 120) { Console.Clear(); Console.WriteLine("                                                                                                                       " + "c"); }
                    if (spacehori == 121) { Console.Clear(); Console.WriteLine("                                                                                                                        " + "c"); }
                    if (spacehori == 122) { Console.Clear(); Console.WriteLine("                                                                                                                         " + "c"); }
                    if (spacehori == 123) { Console.Clear(); Console.WriteLine("                                                                                                                          " + "c"); }
                    if (spacehori == 124) { Console.Clear(); Console.WriteLine("                                                                                                                           " + "c"); }
                    if (spacehori == 125) { Console.Clear(); Console.WriteLine("                                                                                                                            " + "c"); }
                    if (spacehori == 126) { Console.Clear(); Console.WriteLine("                                                                                                                             " + "c"); }
                    if (spacehori == 127) { Console.Clear(); Console.WriteLine("                                                                                                                              " + "c"); }
                    if (spacehori == 128) { Console.Clear(); Console.WriteLine("                                                                                                                               " + "c"); }
                    if (spacehori == 129) { Console.Clear(); Console.WriteLine("                                                                                                                                " + "c"); }
                    System.Threading.Thread.Sleep(5);

                }
                while (PlusOrMinus == 2)
                {
                    spacehori--;

                    if (spacehori == 1) { Console.Clear(); Console.WriteLine(" " + "c"); }
                    if (spacehori == 2) { Console.Clear(); Console.WriteLine("  " + "c"); }
                    if (spacehori == 3) { Console.Clear(); Console.WriteLine("   " + "c"); }
                    if (spacehori == 4) { Console.Clear(); Console.WriteLine("    " + "c"); }
                    if (spacehori == 5) { Console.Clear(); Console.WriteLine("     " + "c"); }
                    if (spacehori == 6) { Console.Clear(); Console.WriteLine("      " + "c"); }
                    if (spacehori == 7) { Console.Clear(); Console.WriteLine("       " + "c"); }
                    if (spacehori == 8) { Console.Clear(); Console.WriteLine("        " + "c"); }
                    if (spacehori == 9) { Console.Clear(); Console.WriteLine("         " + "c"); }
                    if (spacehori == 10) { Console.Clear(); Console.WriteLine("         " + "c"); }
                    if (spacehori == 11) { Console.Clear(); Console.WriteLine("          " + "c"); }
                    if (spacehori == 12) { Console.Clear(); Console.WriteLine("           " + "c"); }
                    if (spacehori == 13) { Console.Clear(); Console.WriteLine("            " + "c"); }
                    if (spacehori == 14) { Console.Clear(); Console.WriteLine("             " + "c"); }
                    if (spacehori == 15) { Console.Clear(); Console.WriteLine("              " + "c"); }
                    if (spacehori == 16) { Console.Clear(); Console.WriteLine("               " + "c"); }
                    if (spacehori == 17) { Console.Clear(); Console.WriteLine("                " + "c"); }
                    if (spacehori == 18) { Console.Clear(); Console.WriteLine("                 " + "c"); }
                    if (spacehori == 19) { Console.Clear(); Console.WriteLine("                  " + "c"); }
                    if (spacehori == 20) { Console.Clear(); Console.WriteLine("                   " + "c"); }
                    if (spacehori == 21) { Console.Clear(); Console.WriteLine("                    " + "c"); }
                    if (spacehori == 22) { Console.Clear(); Console.WriteLine("                     " + "c"); }
                    if (spacehori == 23) { Console.Clear(); Console.WriteLine("                      " + "c"); }
                    if (spacehori == 24) { Console.Clear(); Console.WriteLine("                       " + "c"); }
                    if (spacehori == 25) { Console.Clear(); Console.WriteLine("                        " + "c"); }
                    if (spacehori == 26) { Console.Clear(); Console.WriteLine("                         " + "c"); }
                    if (spacehori == 27) { Console.Clear(); Console.WriteLine("                          " + "c"); }
                    if (spacehori == 28) { Console.Clear(); Console.WriteLine("                           " + "c"); }
                    if (spacehori == 29) { Console.Clear(); Console.WriteLine("                            " + "c"); }
                    if (spacehori == 30) { Console.Clear(); Console.WriteLine("                             " + "c"); }
                    if (spacehori == 31) { Console.Clear(); Console.WriteLine("                              " + "c"); }
                    if (spacehori == 32) { Console.Clear(); Console.WriteLine("                               " + "c"); }
                    if (spacehori == 33) { Console.Clear(); Console.WriteLine("                                " + "c"); }
                    if (spacehori == 34) { Console.Clear(); Console.WriteLine("                                 " + "c"); }
                    if (spacehori == 35) { Console.Clear(); Console.WriteLine("                                  " + "c"); }
                    if (spacehori == 36) { Console.Clear(); Console.WriteLine("                                   " + "c"); }
                    if (spacehori == 37) { Console.Clear(); Console.WriteLine("                                    " + "c"); }
                    if (spacehori == 38) { Console.Clear(); Console.WriteLine("                                     " + "c"); }
                    if (spacehori == 39) { Console.Clear(); Console.WriteLine("                                      " + "c"); }
                    if (spacehori == 40) { Console.Clear(); Console.WriteLine("                                       " + "c"); }
                    if (spacehori == 41) { Console.Clear(); Console.WriteLine("                                        " + "c"); }
                    if (spacehori == 42) { Console.Clear(); Console.WriteLine("                                         " + "c"); }
                    if (spacehori == 43) { Console.Clear(); Console.WriteLine("                                          " + "c"); }
                    if (spacehori == 44) { Console.Clear(); Console.WriteLine("                                           " + "c"); }
                    if (spacehori == 45) { Console.Clear(); Console.WriteLine("                                            " + "c"); }
                    if (spacehori == 46) { Console.Clear(); Console.WriteLine("                                             " + "c"); }
                    if (spacehori == 47) { Console.Clear(); Console.WriteLine("                                              " + "c"); }
                    if (spacehori == 48) { Console.Clear(); Console.WriteLine("                                               " + "c"); }
                    if (spacehori == 49) { Console.Clear(); Console.WriteLine("                                                " + "c"); }
                    if (spacehori == 50) { Console.Clear(); Console.WriteLine("                                                 " + "c"); }
                    if (spacehori == 51) { Console.Clear(); Console.WriteLine("                                                  " + "c"); }
                    if (spacehori == 52) { Console.Clear(); Console.WriteLine("                                                   " + "c"); }
                    if (spacehori == 53) { Console.Clear(); Console.WriteLine("                                                    " + "c"); }
                    if (spacehori == 54) { Console.Clear(); Console.WriteLine("                                                     " + "c"); }
                    if (spacehori == 55) { Console.Clear(); Console.WriteLine("                                                      " + "c"); }
                    if (spacehori == 56) { Console.Clear(); Console.WriteLine("                                                       " + "c"); }
                    if (spacehori == 57) { Console.Clear(); Console.WriteLine("                                                        " + "c"); }
                    if (spacehori == 58) { Console.Clear(); Console.WriteLine("                                                         " + "c"); }
                    if (spacehori == 59) { Console.Clear(); Console.WriteLine("                                                          " + "c"); }
                    if (spacehori == 60) { Console.Clear(); Console.WriteLine("                                                           " + "c"); }
                    if (spacehori == 61) { Console.Clear(); Console.WriteLine("                                                            " + "c"); }
                    if (spacehori == 62) { Console.Clear(); Console.WriteLine("                                                             " + "c"); }
                    if (spacehori == 63) { Console.Clear(); Console.WriteLine("                                                              " + "c"); }
                    if (spacehori == 64) { Console.Clear(); Console.WriteLine("                                                               " + "c"); }
                    if (spacehori == 65) { Console.Clear(); Console.WriteLine("                                                                " + "c"); }
                    if (spacehori == 66) { Console.Clear(); Console.WriteLine("                                                                 " + "c"); }
                    if (spacehori == 67) { Console.Clear(); Console.WriteLine("                                                                  " + "c"); }
                    if (spacehori == 68) { Console.Clear(); Console.WriteLine("                                                                   " + "c"); }
                    if (spacehori == 69) { Console.Clear(); Console.WriteLine("                                                                    " + "c"); }
                    if (spacehori == 70) { Console.Clear(); Console.WriteLine("                                                                     " + "c"); }
                    if (spacehori == 71) { Console.Clear(); Console.WriteLine("                                                                      " + "c"); }
                    if (spacehori == 72) { Console.Clear(); Console.WriteLine("                                                                       " + "c"); }
                    if (spacehori == 73) { Console.Clear(); Console.WriteLine("                                                                        " + "c"); }
                    if (spacehori == 74) { Console.Clear(); Console.WriteLine("                                                                         " + "c"); }
                    if (spacehori == 75) { Console.Clear(); Console.WriteLine("                                                                          " + "c"); }
                    if (spacehori == 76) { Console.Clear(); Console.WriteLine("                                                                           " + "c"); }
                    if (spacehori == 77) { Console.Clear(); Console.WriteLine("                                                                            " + "c"); }
                    if (spacehori == 78) { Console.Clear(); Console.WriteLine("                                                                             " + "c"); }
                    if (spacehori == 79) { Console.Clear(); Console.WriteLine("                                                                              " + "c"); }
                    if (spacehori == 80) { Console.Clear(); Console.WriteLine("                                                                               " + "c"); }
                    if (spacehori == 81) { Console.Clear(); Console.WriteLine("                                                                                " + "c"); }
                    if (spacehori == 82) { Console.Clear(); Console.WriteLine("                                                                                 " + "c"); }
                    if (spacehori == 83) { Console.Clear(); Console.WriteLine("                                                                                  " + "c"); }
                    if (spacehori == 84) { Console.Clear(); Console.WriteLine("                                                                                   " + "c"); }
                    if (spacehori == 85) { Console.Clear(); Console.WriteLine("                                                                                    " + "c"); }
                    if (spacehori == 86) { Console.Clear(); Console.WriteLine("                                                                                     " + "c"); }
                    if (spacehori == 87) { Console.Clear(); Console.WriteLine("                                                                                      " + "c"); }
                    if (spacehori == 88) { Console.Clear(); Console.WriteLine("                                                                                       " + "c"); }
                    if (spacehori == 89) { Console.Clear(); Console.WriteLine("                                                                                        " + "c"); }
                    if (spacehori == 90) { Console.Clear(); Console.WriteLine("                                                                                         " + "c"); }
                    if (spacehori == 91) { Console.Clear(); Console.WriteLine("                                                                                          " + "c"); }
                    if (spacehori == 92) { Console.Clear(); Console.WriteLine("                                                                                           " + "c"); }
                    if (spacehori == 93) { Console.Clear(); Console.WriteLine("                                                                                            " + "c"); }
                    if (spacehori == 94) { Console.Clear(); Console.WriteLine("                                                                                             " + "c"); }
                    if (spacehori == 95) { Console.Clear(); Console.WriteLine("                                                                                              " + "c"); }
                    if (spacehori == 96) { Console.Clear(); Console.WriteLine("                                                                                               " + "c"); }
                    if (spacehori == 97) { Console.Clear(); Console.WriteLine("                                                                                                " + "c"); }
                    if (spacehori == 98) { Console.Clear(); Console.WriteLine("                                                                                                 " + "c"); }
                    if (spacehori == 99) { Console.Clear(); Console.WriteLine("                                                                                                  " + "c"); }
                    if (spacehori == 100) { Console.Clear(); Console.WriteLine("                                                                                                   " + "c"); }
                    if (spacehori == 101) { Console.Clear(); Console.WriteLine("                                                                                                    " + "c"); }
                    if (spacehori == 102) { Console.Clear(); Console.WriteLine("                                                                                                     " + "c"); }
                    if (spacehori == 103) { Console.Clear(); Console.WriteLine("                                                                                                      " + "c"); }
                    if (spacehori == 104) { Console.Clear(); Console.WriteLine("                                                                                                       " + "c"); }
                    if (spacehori == 105) { Console.Clear(); Console.WriteLine("                                                                                                        " + "c"); }
                    if (spacehori == 106) { Console.Clear(); Console.WriteLine("                                                                                                         " + "c"); }
                    if (spacehori == 107) { Console.Clear(); Console.WriteLine("                                                                                                          " + "c"); }
                    if (spacehori == 108) { Console.Clear(); Console.WriteLine("                                                                                                           " + "c"); }
                    if (spacehori == 109) { Console.Clear(); Console.WriteLine("                                                                                                            " + "c"); }
                    if (spacehori == 110) { Console.Clear(); Console.WriteLine("                                                                                                             " + "c"); }
                    if (spacehori == 111) { Console.Clear(); Console.WriteLine("                                                                                                              " + "c"); }
                    if (spacehori == 112) { Console.Clear(); Console.WriteLine("                                                                                                               " + "c"); }
                    if (spacehori == 113) { Console.Clear(); Console.WriteLine("                                                                                                                " + "c"); }
                    if (spacehori == 114) { Console.Clear(); Console.WriteLine("                                                                                                                 " + "c"); }
                    if (spacehori == 115) { Console.Clear(); Console.WriteLine("                                                                                                                  " + "c"); }
                    if (spacehori == 116) { Console.Clear(); Console.WriteLine("                                                                                                                   " + "c"); }
                    if (spacehori == 117) { Console.Clear(); Console.WriteLine("                                                                                                                    " + "c"); }
                    if (spacehori == 118) { Console.Clear(); Console.WriteLine("                                                                                                                     " + "c"); }
                    if (spacehori == 119) { Console.Clear(); Console.WriteLine("                                                                                                                      " + "c"); }
                    if (spacehori == 120) { Console.Clear(); Console.WriteLine("                                                                                                                       " + "c"); }
                    if (spacehori == 121) { Console.Clear(); Console.WriteLine("                                                                                                                        " + "c"); }
                    if (spacehori == 122) { Console.Clear(); Console.WriteLine("                                                                                                                         " + "c"); }
                    if (spacehori == 123) { Console.Clear(); Console.WriteLine("                                                                                                                          " + "c"); }
                    if (spacehori == 124) { Console.Clear(); Console.WriteLine("                                                                                                                           " + "c"); }
                    if (spacehori == 125) { Console.Clear(); Console.WriteLine("                                                                                                                            " + "c"); }
                    if (spacehori == 126) { Console.Clear(); Console.WriteLine("                                                                                                                             " + "c"); }
                    if (spacehori == 127) { Console.Clear(); Console.WriteLine("                                                                                                                              " + "c"); }
                    if (spacehori == 128) { Console.Clear(); Console.WriteLine("                                                                                                                               " + "c"); }
                    if (spacehori == 129) { Console.Clear(); Console.WriteLine("                                                                                                                                " + "c"); }
                    System.Threading.Thread.Sleep(5);

                }



            }
        }
        
    

        
        static void background()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            background();
        }
        static void runTracker()
        {
            while (true)
            {
                Console.Write("enter the distance in miles ");
                double distanceRan = double.Parse(System.Console.ReadLine());
                Console.Write("enter the time it took in minutes ");
                double timeran = double.Parse(System.Console.ReadLine());

                double averageamp = (timeran / distanceRan);
                Console.WriteLine("it took about" + " " + averageamp + " " + "minutes to run a mile");
            }
        }
        static void numcheck()
        {
            Console.Write("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            string size = "nothing";
            if (number >= 100) size = "big";
            if (number <= 100) size = "small";
            else
            { Console.Write(" "); }

            Console.Write("that is a" + " " + size + " " + "number");
        }
        static void Main(string[] args)
        {
            letters();
        }
    }
}
