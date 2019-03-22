using System;
using System.Text;

namespace Models
{
    public class LeadDate
    {
        public DateTime? ClosingDate;
        public DateTime? ContractClosingDate;
        public DateTime? EstimatedClosingDate;
        public DateTime? CenlarTransferDate;

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Lead Date\n");
            stringBuilder.AppendFormat("\tClosing Date: {0}\n", ClosingDate);
            stringBuilder.AppendFormat("\tContract Closing Date: {0}\n", ContractClosingDate);
            stringBuilder.AppendFormat("\tEstimated Closing Date: {0}\n", EstimatedClosingDate);
            stringBuilder.AppendFormat("\tCenlar Transfer Date: {0}\n", CenlarTransferDate);

            return stringBuilder.ToString();
        }
    }
}
