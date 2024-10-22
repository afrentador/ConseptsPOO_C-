namespace POOConcepts
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Frisname { get; set; }

        public string LastName { get; set; }

        public Date Birthday { get; set; }

        public Date HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetvalueToPay();

        public override string ToString()
        {
            return $"{Id} - {Frisname} {LastName}," +
                $" Birth: {Birthday}," +
                $" Hiring: {HiringDate}, " +
                $"Is active: {IsActive}";
        }
    }
}
