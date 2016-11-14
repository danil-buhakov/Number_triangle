using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Number_triangle
{
    class Program
    {


        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("inp.txt");
            string temp, line = "";
            int num_lines = 0;
            while ((temp = file.ReadLine()) != null)
            {
                line += temp + ' ';
                num_lines++;
            }
            file.Close();
            string[] int_line = line.Split(' ');
            int[][] inp = new int[num_lines][];
            for (int i = 0; i < num_lines; i++)
                inp[i] = new int[i + 1];
            int count = 0;
            for (int i = 0; i < num_lines; i++)
                for (int j = 0; j <= i; j++)
                {
                    inp[i][j] = Convert.ToInt32(int_line[count]);
                    count++;
                }

            int max;
            for (int i = num_lines - 2; i >= 0; i--)
                for (int j = i; j >= 0; j--)
                {
                    max = 0;
                    max = inp[i + 1][j];
                    if (j != 0)
                    { 
                        if (inp[i+1][j-1] > max)
                            max = inp[i+1][j-1];
                    }
                    if (inp[i+1][j+1] > max)
                        max = inp[i+1][j+1];
                    max += inp[i][j];
                    inp[i][j] = max;
                }
            Console.WriteLine("Основное задание, максимальная сумма: "+inp[0][0]);
            file = new StreamReader("inp_add_task.txt");
            line = "";
            num_lines = 0;
            while ((temp = file.ReadLine()) != null)
            {
                line += temp + ' ';
                num_lines++;
            }
            file.Close();
            int_line = line.Split(' ');
            inp = new int[num_lines][];
            for (int i = 0; i < num_lines; i++)
                inp[i] = new int[i + 1];
            count = 0;
            for (int i = 0; i < num_lines; i++)
                for (int j = 0; j <= i; j++)
                {
                    inp[i][j] = Convert.ToInt32(int_line[count]);
                    count++;
                }
            for (int i = num_lines - 2; i >= 0; i--)
                for (int j = i; j >= 0; j--)
                {
                    max = 0;
                    max = inp[i + 1][j];
                    if (j != 0)
                    {
                        if (inp[i + 1][j - 1] > max)
                            max = inp[i + 1][j - 1];
                    }
                    if (inp[i + 1][j + 1] > max)
                        max = inp[i + 1][j + 1];
                    max += inp[i][j];
                    inp[i][j] = max;
                }
            Console.WriteLine("Дополнительное задания, максимальная сумма: "+inp[0][0]);
        }
    }
}
