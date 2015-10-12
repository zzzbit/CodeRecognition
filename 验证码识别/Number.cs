using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BmpNumber
{
    class Number
    {

        //数字特征库

        static int[,] _num0 = new int[7, 10] { { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 

                                        { 1, 1, 1, 0, 0, 0, 0, 1, 1, 1 }, { 1, 1, 0, 0, 0, 0, 0, 0, 1, 1 }, 

                                        { 1, 1, 1, 0, 0, 0, 0, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 } };

        static int[,] _num1 = new int[7, 10] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 }, 

                                        { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 

                                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        static int[,] _num2 = new int[7, 10] { { 0, 0, 1, 1, 0, 0, 0, 0, 1, 1 }, { 0, 1, 1, 1, 0, 0, 0, 1, 1, 1 }, 

                                        { 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 }, { 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, { 1, 1, 1, 1, 1, 0, 0, 0, 1, 1 }, { 0, 1, 1, 1, 0, 0, 0, 0, 1, 1 } };

        static int[,] _num3 = new int[7, 10] { { 0, 0, 1, 0, 0, 0, 1, 1, 0, 0 }, { 0, 1, 1, 0, 0, 0, 1, 1, 1, 0 }, 

                                        { 1, 1, 0, 0, 0, 0, 0, 1, 1, 1 }, { 1, 1, 0, 0, 1, 0, 0, 0, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 0, 0, 0, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 1, 1, 1, 0, 1, 1, 1, 0, 0 } };

        static int[,] _num4 = new int[7, 10] { { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0 }, 

                                        { 0, 0, 1, 1, 1, 0, 1, 1, 0, 0 }, { 0, 1, 1, 0, 0, 0, 1, 1, 0, 0 }, 

                                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0 } };

        static int[,] _num5 = new int[7, 10] { { 0, 0, 0, 1, 1, 1, 0, 1, 1, 0 }, { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1 }, 

                                        { 1, 1, 1, 1, 1, 0, 0, 0, 1, 1 }, { 1, 1, 0, 1, 1, 0, 0, 0, 1, 1 },

                                        { 1, 1, 0, 1, 1, 0, 0, 0, 1, 1 }, { 1, 1, 0, 1, 1, 1, 1, 1, 1, 0 }, { 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 } };

        static int[,] _num6 = new int[7, 10] { { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 

                                        { 1, 1, 1, 0, 1, 1, 0, 0, 1, 1 }, { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1, 1, 1, 1, 1, 1 }, { 0, 1, 1, 0, 0, 1, 1, 1, 1, 0 } };

        static int[,] _num7 = new int[7, 10] { { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, 

                                        { 1, 1, 0, 0, 0, 0, 0, 1, 1, 1 }, { 1, 1, 0, 0, 1, 1, 1, 1, 1, 1 }, 

                                        { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 } };

        static int[,] _num8 = new int[7, 10] { { 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 0, 0, 1, 1, 1, 0 } };

        static int[,] _num9 = new int[7, 10] { { 0, 1, 1, 1, 1, 0, 0, 1, 1, 0 }, { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 }, 

                                        { 1, 1, 0, 0, 1, 1, 0, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, { 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 } };



        static private int[,] getNum(Bitmap bmp, int index)
        {

            //分割图片

            int[,] _num = new int[7, 10];

            for (int i = index * 10 + 2; i < index * 10 + 9; i++)
            {

                for (int j = 6; j < 16; j++)
                {

                    Color c = bmp.GetPixel(i, j);

                    if (c.R < 100)
                    {

                        _num[i - 2 - index * 10, j - 6] = 1;

                    }

                }

            }

            return _num;

        }



        static private int CheckNumber(int[,] number)
        {

            if (CheckNumber(_num0, number) == true) return 0;

            if (CheckNumber(_num1, number) == true) return 1;

            if (CheckNumber(_num2, number) == true) return 2;

            if (CheckNumber(_num3, number) == true) return 3;

            if (CheckNumber(_num4, number) == true) return 4;

            if (CheckNumber(_num5, number) == true) return 5;

            if (CheckNumber(_num6, number) == true) return 6;

            if (CheckNumber(_num7, number) == true) return 7;

            if (CheckNumber(_num8, number) == true) return 8;

            if (CheckNumber(_num9, number) == true) return 9;

            return 6;

        }

        static private bool CheckNumber(int[,] dic, int[,] number)
        {

            //逐个匹配

            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (dic[i, j] == 1 && number[i, j] != 1)
                    {

                        return false;

                    }

                }



            }

            return true;

        }



        static public string getNumber(Bitmap bmp)
        {

            //调用

            string str = "";

            for (int i = 0; i <= 3; i++)
            {

                int[,] number = getNum(bmp, i);



                int m = CheckNumber(number);

                str += m.ToString();

            }

            return str;

        }

    }

}
