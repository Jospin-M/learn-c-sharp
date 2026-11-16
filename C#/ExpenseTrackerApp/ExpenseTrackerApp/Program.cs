namespace ExpenseTrackerApp
{ 
    internal class Program
    {
        [Flags]
        public enum ExpenseType
        {
            None = 0,
            Travel = 1,
            Meals = 2,
            OfficeSupplies = 4,
            Software = 8,
            Entertainment = 16
        }

        public enum ApprovalStage
        {
            Draft = 1,
            Submitted = 2,
            UnderReview = 3,
            Approved = 4,
            Rejected = 5
        }

        static void Main(string[] args)
        {
            string[] expenseTypes = Enum.GetNames<ExpenseType>();

            foreach(string type in expenseTypes)
            {
                Console.WriteLine(type);
            }

            Console.WriteLine();

            ExpenseType expenses = ExpenseType.Travel | ExpenseType.Meals;

            if((expenses & ExpenseType.Meals) == ExpenseType.Meals)
            {
                Console.WriteLine("Expense includes: Meals");
            } 
            else
            {
                Console.WriteLine("Expense does not include: Meals");
            }

            Console.WriteLine();

            expenses &= ~ExpenseType.Meals;

            Console.WriteLine(expenses);
            Console.WriteLine();

            bool success = Enum.TryParse<ExpenseType>("Meals, Software", out ExpenseType parsedExpense);

            if(success)
            {
                Console.WriteLine(parsedExpense);
            }
            else
            {
                Console.WriteLine("Parse failed.");
            }

            Console.WriteLine();

            int[] stages = (int[])Enum.GetValues(typeof(ApprovalStage));

            foreach(int stage in stages)
            {
                Console.WriteLine(Enum.GetName(typeof(ApprovalStage), stage));
            }

            Console.WriteLine();

            bool success2 = Enum.TryParse<ApprovalStage>("Submitted", out ApprovalStage parsedStage);

            if(success2)
            {
                Console.WriteLine(parsedStage);
            }
            else
            {
                Console.WriteLine("Parse failed.");
            }

            Console.WriteLine();

            int approvalValue = 4;

            bool defined = Enum.IsDefined(typeof(ApprovalStage), approvalValue);

            if(defined)
            {
                Console.WriteLine((ApprovalStage)approvalValue);
            }
            else
            {
                Console.WriteLine("Value not defined.");
            }

            Console.WriteLine();

            ApprovalStage currentStage = ApprovalStage.UnderReview;

            switch (currentStage)
            {
                case ApprovalStage.UnderReview:
                    Console.WriteLine("Correct!");
                    break;

                default:
                    Console.WriteLine("Invalid value");
                    break;
            }

            Console.WriteLine();

            ExpenseType validExpense = ExpenseType.OfficeSupplies | ExpenseType.Software;
            bool valid = Enum.IsDefined(typeof(ApprovalStage), "Meals");

            if(valid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine();

            currentStage = ApprovalStage.Approved;

            Console.WriteLine(validExpense);
            Console.WriteLine(currentStage);
        }
    }
}
