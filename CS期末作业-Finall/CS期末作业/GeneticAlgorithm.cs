using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS期末作业
{
    class GeneticAlgorithm
    {
        //约束变量
        private const double a1 = -3.0;
        private const double b1 = 12.1;
        private const double a2 = 4.1;
        private const double b2 = 5.8;
        //小数点后保留精度
        private const double precison = 100000;
        //码位，二进制编码长度
        int x1Len;
        int x2Len;
        int Len ;
        //群体大小
        int M;
        //进化代数
        int T;
        //交叉概率
        double Pc;
        //变异概率
        double Pm;
        //存储一个群体的染色体，即二进制编码
        byte[,] population;
        //存储实际变量值
        double[,] data;
        //存储所有的函数值 
        double[] value;
        //最终输出结果
        double[] output;
        //全局随机数生成器
        Random random = new Random();

        public GeneticAlgorithm(int M, int T, double Pc, double Pm)
        {
            this.M = M;
            this.T = T;
            this.Pc = Pc;
            this.Pm = Pm;
            Len = CalLen(a1, b1, a2, b2, precison);
            population = new byte[M, Len];
            data = new double[M, 2];
            value = new double[M];
            output = new double[3];
//MessageBox.Show(""+Len);
        }

        public double[] Solveproblem()
        {
            //利用随机方式产生规模为M的初始种群
            ProduceGroup();
            //计算出对应的十进制
            DecodeGroup();
            //FindMax();
            for (int i = 0; i < M; ++i)
            {
                //复制（选择）运算，交叉（交换）运算，变异运算
                MakeCopy();
                DoSwitch();
                DoMutation();
                //解码然后计算出函数值
                DecodeGroup();
                //Mark the Max Value
                FindMax();
            }
            return output;
        }

        /// <summary>
        /// 默认系统初始为0
        /// 从每一次的“传宗接代”中找到最大值
        /// </summary>
        public void FindMax()
        {
            for (int i = 0; i < M; ++i)
            {
                if (value[i] > output[2])
                {
                    output[0] = data[i, 0];
                    output[1] = data[i, 1];
                    output[2] = value[i];
                }
            }
        }

        /// <summary>
        /// 计算二进制串的长度
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <param name="a2"></param>
        /// <param name="b2"></param>
        /// <param name="precison"></param>
        /// <returns></returns>
        public int CalLen(double a1, double b1, double a2, double b2, double precison)
        {
            x1Len = Convert.ToInt32(Math.Ceiling(Math.Log((b1 - a1) * precison, 2)));
            x2Len = Convert.ToInt32(Math.Ceiling(Math.Log((b2 - a2) * precison, 2)));
//MessageBox.Show("" + x2Len);
            return x1Len + x2Len;
        }

        /// <summary>
        /// 产生一个初始群体（编码）
        /// </summary>
        public void ProduceGroup()
        {
            for(int i=0 ; i<this.M ; ++i)
            {
                for(int j=0 ; j<this.Len ; ++j)
                {
                    //随机产生0~1
                    if (random.NextDouble() > 0.5)
                        population[i, j] = 1;
                    else
                        population[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// 解码
        /// </summary>
        public void DecodeGroup()
        {
            double temp = 0;
            for (int i = 0; i < this.M; ++i)
            {
                for (int j = 0; j < x1Len; ++j)
                {
                    temp += population[i, j] * Math.Pow(2, j);
                }
                //解码方式
                data[i, 0] = temp * (b1- a1) / (Math.Pow(2, x1Len) - 1) + a1  ;
               
                temp = 0;
                for (int j = x1Len; j < Len; ++j)
                {
                    temp += population[i, j] * Math.Pow(2, j - x1Len);
                }
                data[i, 1] = temp * (b2 - a2) / (Math.Pow(2, x2Len) - 1) + a2 ;
            }
            //代入计算出函数的值
            for (int i = 0; i < this.M; ++i)
            {
                double x1 = data[i, 0], x2 = data[i, 1];
                value[i] =21.5 + x1 * Convert.ToDouble(Math.Sin(4 * Math.PI * Convert.ToDouble(x1) )) + x2 * Convert.ToDouble(Math.Sin(20 * Math.PI * Convert.ToDouble(x2)));
            }
        }

        public void MakeCopy()
        {
            double sum = 0;
            double[] Pi = new double[M];
            //double[] Ri = new double[M];
            //轮盘法做复制，随机产生10个0~1数字
            for (int i = 0; i < this.M; ++i)
            {
                sum += value[i];
                //Ri[i] = random.NextDouble();
            }
            //Pi[i]存储的是个体i的累积概率，最后一个显然是1
//由于进位的原因，Pi[M-1]一般不等于1，尽管理论上应该等于1
            for (int i = 0; i < M; ++i)
            {
                Pi[i] = value[i] / sum;
                if(i!=0)
                    Pi[i] += Pi[i-1];
            }
            //轮盘赌法
            for (int i = 0; i < M; ++i)
            {
                double r = random.NextDouble();
                for (int j = 0; j < M; ++j)
                {
                    if (r < Pi[j])
                    {
                        for (int k = 0; k < Len; ++k)
                        {
                            SwapByte(ref population[i, k], ref population[j, k]);
                        }
                        break;
                    }
                }
            }
//MessageBox.Show(""+Pi[M-1]);
        }

        public void SwapByte(ref byte b1, ref byte b2)
        {
            byte temp = b1;
            b1 = b2;
            b2 = temp;
        }

        /// <summary>
        /// 单点交叉算子 交叉概率 Pc
        /// </summary>
        public void DoSwitch()
        {
            int[] r = new int[M];
            int cnt = 0;
            for (int i = 0; i < M; ++i)
            {
                if (random.NextDouble() < Pc)
                {
                    r[cnt] = i;
                    //r.Length
                    cnt++;
                }
            }
 //这里有待改进，书上说，应该是组 M/2 进行随机配对
            //对cnt/2组进行随机配对
            for (int i = 0; i < cnt; i = i + 2)
            {
                //若染色体的长度为N，则有（N-1）中可能的交叉点位置
                int index1 = random.Next(1, x1Len);//[1, Len)
                int index2 = random.Next(1 + x2Len, Len);//[1, Len)
                for (int j = index1; j < x1Len; ++j)
                {
                    SwapByte(ref population[r[i], j], ref population[r[i + 1], j]);
                }
                for (int j = index2; j < Len; ++j)
                {
                    SwapByte(ref population[r[i], j], ref population[r[i + 1], j]);
                }
            }
        }


        /// <summary>
        /// 在指定位置突变 0变成1,1变成0
        /// 数组内所有二进制的指定位置  index / (M*Len)
        /// </summary>
        public void DoMutation()
        {
            //平均每代会有cnt个基因发生突变
            int cnt = Convert.ToInt32(Math.Ceiling(Pm * M * Len));
            for (int k = 0; k < cnt; ++k)
            {
                int index = random.Next(M * Len);
                int i = index / Len;
                int j = index - Len * i;
                if (population[i, j] == 1)
                    population[i, j] = 0;
                else
                    population[i, j] = 1;
            }
            //
            //for (int i = 0; i < M; ++i)
            //{
            //    for (int j = 0; j < Len; ++j)
            //    {
            //        if (random.NextDouble() < Pm)
            //        {
            //            if (population[i, j] == 1)
            //                population[i, j] = 0;
            //            else
            //                population[i, j] = 1;
            //        }
            //    }
            //}
        }
    }
}
