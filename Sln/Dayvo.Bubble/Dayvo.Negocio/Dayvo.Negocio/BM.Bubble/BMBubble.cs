using Dayvo.Negocio.Interfaz;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dayvo.Negocio.BM.Bubble
{
    public class BMBubble: ICollectionSorter
    {
        public IEnumerable<string> SortAscending(int[] numbers) {
            IEnumerable<string> Result = OrderBurbuja(numbers, true);
            return Result;
        }
        public IEnumerable<string> SortDescending(int[] numbers) {
            IEnumerable<string>  Result= OrderBurbuja(numbers, false);
            return Result;
        }
        public IEnumerable<string> OrderBurbuja(int[] numbers, Boolean Asc)
        {
            //This pseudocode order values according Boolean Asc Parameter

            //Bubble pseudocode :
            //            procedure bubbleSort(A : list of sortable items)
            //    n:= length(A)
            //    repeat
            //        swapped := false
            //        for i := 1 to n - 1 inclusive do
            //                    /* if this pair is out of order */
            //                    if A[i - 1] > A[i] then
            //                  /* swap them and remember something changed */
            //                  swap(A[i - 1], A[i])
            //                swapped:= true
            //            end if
            //        end for
            //    until not swapped
            //end procedure

            //Here start Implementation or ordering algorithm:
            //If Asc = true Result Array will be Ascendent
            //If Asc = false Result Array will be Descendent
            int length = numbers.Count();
            int numeroIteraciones = 0;
            if (length > 0)
            {
                try
                {
                    Boolean swapped = false;
                    do
                    {

                        numeroIteraciones++;  //Cantida de Iteraciones
                        if (numeroIteraciones > ushort.MaxValue)
                        {
                            throw new OutofRangeException("Cantidad Máxima de Iteraciones");
                        }

                        swapped = false;
                        for (int i = 1; i <= length - 1; i++)
                        {
                            if (Asc == true && ((int)numbers.GetValue(i - 1) > (int)numbers.GetValue(i)))
                            {
                                //Se solicitó ordenar de manera Ascendente y encontró que un par de valores para ordenar
                                int anterior = (int)numbers.GetValue(i - 1);
                                numbers.SetValue((int)numbers.GetValue(i), i - 1);
                                numbers.SetValue(anterior, i);
                                swapped = true;
                            }
                            else if (Asc == false && ((int)numbers.GetValue(i - 1) < (int)numbers.GetValue(i)))
                            {
                                //Se solicitó ordenar de manera Descendente y encontró que un par de valores para ordenar
                                int anterior = (int)numbers.GetValue(i - 1);
                                numbers.SetValue((int)numbers.GetValue(i), i - 1);
                                numbers.SetValue(anterior, i);
                                swapped = true;
                            }
                        }
                    } while (swapped == true);
                    Console.WriteLine("El número de Iteraciones fue: " + numeroIteraciones.ToString());
                    Debug.WriteLine("El número de Iteraciones fue: " + numeroIteraciones.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    Debug.WriteLine(ex.Message.ToString());
                    
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    //Retornar lista ordenada con el formato solicitado:

                    switch (true)
                    {
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^0$"):
                            yield return "ZeRo";
                            break;

                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^1$"):
                            yield return "ONE";
                            break;
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^2$"):
                            yield return "two";
                            break;

                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^3$"):
                            yield return "THREE";
                            break;
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^4$"):
                            yield return "four";
                            break;

                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^5$"):
                            yield return "FIVE";
                            break;
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^6$"):
                            yield return "six";
                            break;

                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^7$"):
                            yield return "SEVEN";
                            break;
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^8$"):
                            yield return "eight";
                            break;
                        case bool _ when Regex.IsMatch(numbers.GetValue(i).ToString(), @"^9$"):
                            yield return "NINE";
                            break;
                        default:
                            yield return numbers.GetValue(i).ToString();
                            break;
                    }

                }

            }
        }
        public class OutofRangeException : Exception
        {
            public OutofRangeException(string message)
                : base(message)
            {
            }
        }

    }
}
