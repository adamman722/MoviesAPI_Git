namespace MoviesAPI_Git.DTO
{
    public class Loan
    {
        public Guid Id { get; set; }
        public string loan_number { get; set; }
        public string borrower_first_name { get; set; }
        public string borrower_middle_initial { get; set; }
        public int loan_amount { get; set; }
        public float interest_rate { get; set; }
        public int term_years { get; set; }
        public int down_payment { get; set; }
        public int property_value { get; set; }
        public float monthly_payment { get; set; }
        public float total_interest_paid { get; set; }
        public float total_payment { get; set; }




        public Loan(LoanRequest lr)
        {
            Id = Guid.NewGuid();
            borrower_first_name = lr.borrower_first_name;
            borrower_middle_initial = lr.borrower_middle_initial;
            loan_number = lr.loan_number;
            loan_amount = lr.loan_amount;
            interest_rate = lr.interest_rate;
            term_years = lr.term_years;
            down_payment = lr.down_payment;
            property_value = lr.property_value;
            monthly_payment = lr.monthly_payment;
            total_interest_paid = lr.total_interest_paid;
            total_payment = lr.total_payment;

        }

        public Loan(string loan_number, string borrower_first_name, string borrower_middle_initial, int loan_amount, float interest_rate, int term_years, int down_payment, int property_value, float monthly_payment, float total_interest_paid, float total_payment)
        {
            Id = Guid.NewGuid();
            this.loan_number = loan_number;
            this.borrower_first_name = borrower_first_name;
            this.borrower_middle_initial = borrower_middle_initial;
            this.loan_amount = loan_amount;
            this.interest_rate = interest_rate;
            this.term_years = term_years;
            this.down_payment = down_payment;
            this.property_value = property_value;
            this.monthly_payment = monthly_payment;
            this.total_interest_paid = total_interest_paid;
            this.total_payment = total_payment;
        }
    }
}
