﻿namespace _2._3._3
{
    /*
     * 2.3.3
     * 
     * 对于长度为 N 的数组，
     * 在 Quick.sort() 执行时，
     * 其最大元素最多会被交换多少次？
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // N / 2
            // 在快速排序中，一个元素要被交换，有以下两种情况
            // 1. 该元素是枢轴，在切分的最后一步被交换
            // 2. 该元素位于枢轴错误的一侧，需要被交换到另一侧去
            // 注意，以上两种情况在一次切分中只会出现一次
            // 
            // 首先来看第一种情况，如果一个元素变成了枢轴
            // 那么在之后的切分中该元素会被排除，不存在后续的交换。
            // 因此我们的目标应该是：
            // 最大的元素总是出现在错误的一侧，同时切分的次数尽可能多。
            // 
            // 接下来我们来思考如何构造这样的数组
            // 由于我们针对的是最大的元素，因此「错误的一侧」就是枢轴的左侧。
            // 为了使切分的次数尽可能多，我们需要保持最大值移动的距离尽量短。
            // 但如果每次只移动一位的话，下一次切分时最大值就会变成枢轴
            // 例如 4 10 3 5 6，枢轴为 4，交换后数组变为：
            // 4 3 10 5 6
            // 随后 4 和 3 交换
            // 3 4 10 5 6
            // 下一次切分时 10 会变成枢轴，不再参与后续的切分。
            // 因此我们需要让最大值每次移动两个元素。
            // 
            // 考虑下面的数组：
            // 2 10 4 1 6 3 8 5 7 9
            // 第一次切分的时候，枢轴为 2，10 和 1 进行交换
            // 数组变为：
            // 2 1 4 10 6 3 8 5 7 9
            // 随后枢轴交换，数组变为：
            // 1 2 4 10 6 3 8 5 7 9
            // 第二次切分，枢轴为 4，10 和 3 进行交换。
            // 1 2 4 3 6 10 8 5 7 9
            // 随后枢轴交换 数组变为：
            // 1 2 3 4 6 10 8 5 7 9
            // 第三次切分，枢轴为 6，10 和 5 交换
            // 1 2 3 4 6 5 8 10 7 9
            // 随后枢轴交换，数组变为：
            // 1 2 3 4 5 6 8 10 7 9
            // 第四次切分，枢轴为 8，10 和 7 交换
            // 1 2 3 4 5 6 8 7 10 9
            // 枢轴交换，数组变为
            // 1 2 3 4 5 6 7 8 10 9
            // 最后一次切分，枢轴为 10，直接交换
            // 1 2 3 4 5 6 7 8 9 10
            // 
            // 我们可以总结出要构造这样的数组的模板
            // a2 max a3 a1
            // 其中 a1 < a2 < a3 < max
            // max 每轮切分移动两格，总共切分 N/2 次。
        }
    }
}
