using Microsoft.AspNetCore.Mvc;
using MoviesAPI_Git.DTO;
using MoviesAPI_Git.Repo;
using System.Net.Http.Headers;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesAPI_Git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private ICollection<Loan> _loans = LoanRepo.loans;
        // GET: api/<LoansController>
        [HttpGet]
        public IActionResult Get()
        {
            return _loans == null ? NotFound() : Ok(_loans);
        }

        // GET api/<LoansController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Loan foundLoan;
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                foundLoan = _loans.First(loan => loan.Id == id);
            }
            catch (Exception e)
            {

                return NotFound();
            }

            return Ok();
        }

        // POST api/<LoansController>
        [HttpPost]
        public IActionResult Post([FromBody] LoanRequest loan)

        {
            if (loan == null)
            {
                return BadRequest();
            }

            Loan createdLoan = new Loan(loan);
            _loans.Add(createdLoan);
            return Created("v1/loans", createdLoan);
        }

        // PUT api/<LoansController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] LoanRequest loan)
        {
            Loan foundLoan = _loans.First(loan => loan.Id == id);
            foundLoan.borrower_first_name = loan.borrower_first_name;
            foundLoan.borrower_middle_initial = loan.borrower_middle_initial;
            foundLoan.loan_amount = loan.loan_amount;
            foundLoan.interest_rate = loan.interest_rate;
            foundLoan.term_years = loan.term_years;
            foundLoan.down_payment = 999999; // Oh beans....
            foundLoan.property_value = loan.property_value;
            foundLoan.monthly_payment = loan.monthly_payment;
            foundLoan.total_interest_paid = loan.total_interest_paid;
            foundLoan.total_payment = loan.total_payment;
            return NoContent();
        }

        // DELETE api/<LoansController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (id == null && !_loans.Contains(_loans.First(loan => loan.Id == id)))
            {
                return NotFound();
            }
            _loans.Remove(_loans.First(loan => loan.Id == id));
            return NoContent();
        }

        [HttpGet, Route("secret")]
        public IActionResult GetSecret([FromQuery] string token)
        {
            Guid guid;
            try
            {
                guid = Guid.Parse(token);

            }
            catch (Exception e)
            {

                return BadRequest("You need to give a valid token");
            }
            if (!TokenManager.ValidUser(guid))
            {
                return Unauthorized("You need to give a valid token");
            }

            return Ok(LoanRepo.secretLoan);
        }

        [HttpGet, Route("secret2EBL")]
        public IActionResult GetSecretSecret()
        {

            IHeaderDictionary headers = Request.Headers;
            if (AuthenticationHeaderValue.TryParse(headers.Authorization, out var headerValue))
            {
                // we have a valid AuthenticationHeaderValue that has the following details:
                var scheme = headerValue.Scheme;
                var parameter = headerValue.Parameter;
                // scheme will be "Bearer"
                // parmameter will be the token itself.
                if (scheme != "Bearer")
                {
                    return BadRequest("Ummmmmmmmmmmmm it needs to be a Bearer Bud.....");
                }
                if (parameter != null)
                {
                    return BadRequest($"{parameter} is not valid");
                }

                //This is with the token gen, hoping this works
                //I am sure there is a better way to conver to Guid but I will ask tomorrow.
                Guid guid = new Guid(parameter);
                if (TokenManager.ValidUser(guid))
                {
                    return Ok(LoanRepo.secretLoan2);
                }

            }

            return BadRequest("You may need to give some tokens to Bear there bud...I am pretty sure I told you this already...silly goose.");
        }



    }
}
