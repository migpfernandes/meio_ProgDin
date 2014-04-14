using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meioTp1_ProgDin
{
    public static class modProgDin
    {
        private static int _dimension;
        public static List<IterationResults> Calculate(List<decimal[,]> projections,
                                     List<decimal[,]> weights,
                                     int dimension,
                                     int iterations,
                                     Operation op)
        {
            List<decimal[]> Q;
            List<decimal[]> Vn = new List<decimal[]>();
            List<IterationResults> res = new List<IterationResults>();

            _dimension = dimension;

            Q = getQ(projections, weights);
            decimal[] Fn = new decimal[dimension];
            decimal[] tmpFn,diffFn;
            for (int i = 0; i < Fn.Length; i++)
            {
                Fn[i] = 0;
            }

            for (int i = 1; i <= iterations; i++)
            {
                Vn = getVn(projections, Q, Fn);
                tmpFn = getFnNextIt(Vn,op);
                diffFn = deltaFn(tmpFn, Fn);
                Fn = tmpFn;
                res.Add(new IterationResults(i, Fn, diffFn, Vn));
            }
            return res;
        }

        private static List<decimal[]> getQ(List<decimal[,]> projections,
                                            List<decimal[,]> weights)
        {
            List<decimal[]> res = new List<decimal[]>();
            decimal[,] projection;
            decimal[,] weight;
            decimal[] q;
            decimal sum;
            for (int i = 0; i < projections.Count; i++)
            {
                projection = projections[i];
                weight = weights[i];
                q = new decimal[_dimension];
                for (int j = 0; j < _dimension; j++)
                {
                    sum = 0;
                    for (int g = 0; g < _dimension; g++)
                    {
                        sum += projection[j, g] * weight[j, g];
                    }
                    q[j] = sum;
                }
                res.Add(q);
            }
            return res;
        }

        private static List<decimal[]> getVn(List<decimal[,]> projections,
                                             List<decimal[]> Q,
                                             decimal[] Fn1)
        {
            List<decimal[]> res = new List<decimal[]>();
            decimal[,] projection;
            decimal[] qn;
            decimal[] aux;
            decimal sum;
            for (int i = 0; i < projections.Count; i++)
            {
                projection = projections[i];
                qn = Q[i];
                aux = new decimal[_dimension];
                for (int j = 0; j < _dimension; j++)
                {
                    sum = 0;
                    for (int g = 0; g < _dimension; g++)
                    {
                        sum += projection[j, g] * Fn1[g];
                    }
                    aux[j] = sum + qn[j];
                }
                res.Add(aux);
            }
            return res;
        }

        private static decimal[] getFnNextIt(List<decimal[]> Vn,
                                             Operation op)
        {
            decimal[] nextFn = new decimal[_dimension];
            for (int i = 0; i < _dimension; i++)
            {
                if (op == Operation.Max)
                {
                    nextFn[i] = Vn.Max(x => x[i]);
                }
                else if (op == Operation.Min)
                {
                    nextFn[i] = Vn.Min(x => x[i]);
                }
                else
                {
                    throw new NotImplementedException("Apenas as operações de maximização e minimização estão definidas.");
                }
            }
            return nextFn;
        }

        private static decimal[] deltaFn(decimal[] newFn, decimal[] oldFn)
        {
            decimal[] res = new decimal[_dimension];
            for (int i = 0; i < _dimension; i++)
            {
                res[i] = newFn[i] - oldFn[i];
            }
            return res;
        }
    }

    public enum Operation { Max, Min };

    public class IterationResults{

        public IterationResults(int iteration, decimal[] fn, decimal[] diffFn, List<decimal[]> vn)
        {
            this.Iteration = iteration;
            this.Fn = fn;
            this.DiffFn = diffFn;
            this.Vn = vn;
        }

        public int Iteration{get;set;}
        public decimal[] Fn { get; set; }
        public decimal[] DiffFn { get; set; }
        public List<decimal[]> Vn{get;set;}
    }

}
