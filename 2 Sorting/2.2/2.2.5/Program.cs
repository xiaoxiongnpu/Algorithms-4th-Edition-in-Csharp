﻿namespace _2._2._5
{
    /*
     * 2.2.5
     * 
     * 当输入数组的大小 N=39 时，
     * 给出自顶向下和自底向上的归并排序中各次归并子数组的大小及顺序。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 自顶向下
            // 2, 3, 2, 5, 2, 3, 2, 5, 10, 2, 3, 2, 5, 2, 3, 2, 5, 10, 20, 2, 3, 2, 5, 2, 3, 2, 5, 10, 2, 3, 2, 5, 2, 2, 4, 9, 19, 39
            // 自底向上
            // 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3, 8, 8, 8, 8, 7, 16, 16, 32, 39
        }
    }
}
