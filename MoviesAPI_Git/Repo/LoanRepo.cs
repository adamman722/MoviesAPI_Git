using MoviesAPI_Git.DTO;
using Newtonsoft.Json;

namespace MoviesAPI_Git.Repo
{
    public class LoanRepo
    {
        private static ICollection<LoanRequest> loanRequests = JsonConvert.DeserializeObject<List<LoanRequest>>("[\r\n  {\r\n    \"loan_number\": \"1121249\",\r\n    \"borrower_first_name\": \"Anthony\",\r\n    \"borrower_middle_initial\": \"H\",\r\n    \"loan_amount\": 2000000,\r\n    \"interest_rate\": 3,\r\n    \"term_years\": 15,\r\n    \"down_payment\": 20000,\r\n    \"property_value\": 2352000,\r\n    \"monthly_payment\": 14005,\r\n    \"total_interest_paid\": 0,\r\n    \"total_payment\": 145000\r\n  },\r\n  {\r\n    \"loan_number\": \"1121250\",\r\n    \"borrower_first_name\": \"Emma\",\r\n    \"borrower_middle_initial\": \"J\",\r\n    \"loan_amount\": 1500000,\r\n    \"interest_rate\": 3.5,\r\n    \"term_years\": 20,\r\n    \"down_payment\": 25000,\r\n    \"property_value\": 1775000,\r\n    \"monthly_payment\": 9553.26,\r\n    \"total_interest_paid\": 152631.81,\r\n    \"total_payment\": 283163.81\r\n  },\r\n  {\r\n    \"loan_number\": \"1121251\",\r\n    \"borrower_first_name\": \"Sophia\",\r\n    \"borrower_middle_initial\": \"L\",\r\n    \"loan_amount\": 1800000,\r\n    \"interest_rate\": 4,\r\n    \"term_years\": 30,\r\n    \"down_payment\": 30000,\r\n    \"property_value\": 2100000,\r\n    \"monthly_payment\": 8594.81,\r\n    \"total_interest_paid\": 279331.3,\r\n    \"total_payment\": 459331.3\r\n  },\r\n  {\r\n    \"loan_number\": \"1121252\",\r\n    \"borrower_first_name\": \"Michael\",\r\n    \"borrower_middle_initial\": \"C\",\r\n    \"loan_amount\": 2200000,\r\n    \"interest_rate\": 3.75,\r\n    \"term_years\": 25,\r\n    \"down_payment\": 40000,\r\n    \"property_value\": 2550000,\r\n    \"monthly_payment\": 10923.65,\r\n    \"total_interest_paid\": 321178.46,\r\n    \"total_payment\": 561178.46\r\n  },\r\n  {\r\n    \"loan_number\": \"1121253\",\r\n    \"borrower_first_name\": \"Olivia\",\r\n    \"borrower_middle_initial\": \"M\",\r\n    \"loan_amount\": 1900000,\r\n    \"interest_rate\": 4.25,\r\n    \"term_years\": 30,\r\n    \"down_payment\": 35000,\r\n    \"property_value\": 2250000,\r\n    \"monthly_payment\": 9320.75,\r\n    \"total_interest_paid\": 402378.28,\r\n    \"total_payment\": 592378.28\r\n  },\r\n  {\r\n    \"loan_number\": \"1121254\",\r\n    \"borrower_first_name\": \"Liam\",\r\n    \"borrower_middle_initial\": \"R\",\r\n    \"loan_amount\": 2500000,\r\n    \"interest_rate\": 3.25,\r\n    \"term_years\": 20,\r\n    \"down_payment\": 50000,\r\n    \"property_value\": 2950000,\r\n    \"monthly_payment\": 14467.67,\r\n    \"total_interest_paid\": 278640.13,\r\n    \"total_payment\": 528640.13\r\n  },\r\n  {\r\n    \"loan_number\": \"1121255\",\r\n    \"borrower_first_name\": \"Ava\",\r\n    \"borrower_middle_initial\": \"S\",\r\n    \"loan_amount\": 2100000,\r\n    \"interest_rate\": 4,\r\n    \"term_years\": 30,\r\n    \"down_payment\": 30000,\r\n    \"property_value\": 2400000,\r\n    \"monthly_payment\": 10009.89,\r\n    \"total_interest_paid\": 379557.13,\r\n    \"total_payment\": 589557.13\r\n  },\r\n  {\r\n    \"loan_number\": \"1121256\",\r\n    \"borrower_first_name\": \"Noah\",\r\n    \"borrower_middle_initial\": \"T\",\r\n    \"loan_amount\": 2300000,\r\n    \"interest_rate\": 3.5,\r\n    \"term_years\": 25,\r\n    \"down_payment\": 45000,\r\n    \"property_value\": 2750000,\r\n    \"monthly_payment\": 11507.49,\r\n    \"total_interest_paid\": 307246.54,\r\n    \"total_payment\": 537246.54\r\n  },\r\n  {\r\n    \"loan_number\": \"1121257\",\r\n    \"borrower_first_name\": \"Isabella\",\r\n    \"borrower_middle_initial\": \"W\",\r\n    \"loan_amount\": 1700000,\r\n    \"interest_rate\": 4.5,\r\n    \"term_years\": 15,\r\n    \"down_payment\": 25000,\r\n    \"property_value\": 1975000,\r\n    \"monthly_payment\": 12918.29,\r\n    \"total_interest_paid\": 215089.18,\r\n    \"total_payment\": 385089.18\r\n  },\r\n  {\r\n    \"loan_number\": \"1121258\",\r\n    \"borrower_first_name\": \"James\",\r\n    \"borrower_middle_initial\": \"K\",\r\n    \"loan_amount\": 2600000,\r\n    \"interest_rate\": 3.75,\r\n    \"term_years\": 20,\r\n    \"down_payment\": 50000,\r\n    \"property_value\": 3100000,\r\n    \"monthly_payment\": 14937.25,\r\n    \"total_interest_paid\": 339340.03,\r\n    \"total_payment\": 589340.03\r\n  }\r\n]\r\n");

   

        public static Loan secretLoan = new Loan("1121240", "Adam", "H", 2652000, 3, 15, 20000, 2352000, 14005, 0, 145000);
        public static Loan secretLoan2 = new Loan("11212416385", "Tony", "S", 2652000, 3, 15, 20000, 2352000, 14005, 0, 145000);
        public static ICollection<Loan> loans = ConverData(loanRequests);

        public static ICollection<Loan> ConverData(ICollection<LoanRequest> lr)
        {
            List<Loan> loans = new List<Loan>();
            foreach (var laon in lr)
            {
                Loan nl = new Loan(laon);
                loans.Add(nl);
            }
            return loans;
        }
    
    }
}
