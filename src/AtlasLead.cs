using System.Collections.Generic;

namespace Models
{
    public class AtlasLead
    {
        public int LeadId { get; set; }
        public int? OfferingId { get; set; }
        public int? PropertyAddressId { get; set; }
        public int? BorrowerId { get; set; }
        public int? CoborrowerId { get; set; }
        public string EncompassLoanNumber { get; set; }
        public string EncompassGuid { get; set; }
        public SubjectPropertyAddress SubjectPropertyAddress { get; set; }
        public Borrower Borrower { get; set; }
        public Borrower CoBorrower { get; set; }
        public List<LoanInformation> LoanInformation { get; set; }
        public List<LeadDate> LeadDates { get; set; }
    }
}
