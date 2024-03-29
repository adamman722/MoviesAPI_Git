namespace MoviesAPI_Git.DTO
{
    public class LoanRequest
    {
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



    }
}
