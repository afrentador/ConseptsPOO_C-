namespace POOConcepts
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetvalueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValue to pay.........: {$"{GetvalueToPay():C2}", 18}";
        }
    }
}
