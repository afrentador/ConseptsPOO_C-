using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPersentaje { get; set; }

        public decimal Sales { get; set; }
        public override decimal GetvalueToPay()
        {
            return Sales * (decimal)CommissionPersentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission persentaje: {$"{CommissionPersentaje:P2}", 18}" +
                $"\n\tSale.................: {$"{Sales:C2}", 18}" +
                $"\n\tValue to pay.........: {$"{GetvalueToPay():C2}", 18}";
        }
    }
}
