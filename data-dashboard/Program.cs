using System;
using System.Net.Http;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;


namespace Database_Dashboard
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Goodbye cruel World!");
            //var guid = Guid.Parse("0a81dd40-0408-45a4-a154-2bbca0b4d8ba");
            var guid = Guid.Parse("d90140f0-5b3d-41a2-adad-c427000a702c");

            var atlasLeadPrefix = "https://atlasapi.d.vu.local/Atlas/lead";

            using (var httpClient = new HttpClient())
            {
                var atlasLeadResult = await httpClient.GetAsync($"{atlasLeadPrefix}/lookup?encompassGuid={guid}");
                var leadId = await atlasLeadResult.Content.ReadAsStringAsync();

                var leadResult = await httpClient.GetAsync($"{atlasLeadPrefix}/{leadId}");
                var leadResultString = await leadResult.Content.ReadAsStringAsync();
                var outObject = JsonConvert.DeserializeObject<AtlasLead>(leadResultString);
                System.Console.WriteLine("LeadId: " + outObject.LeadId);
                System.Console.WriteLine("OfferingId: " + outObject.OfferingId);
                System.Console.WriteLine("PropertyAddressId: " + outObject.PropertyAddressId);
                System.Console.WriteLine("BorrowerId: " + outObject.BorrowerId);
                System.Console.WriteLine("CoborrowerId: " + outObject.CoborrowerId);
                System.Console.WriteLine("EncompassLoanNumber: " + outObject.EncompassLoanNumber);
                System.Console.WriteLine("EncompassGuid: " + outObject.EncompassGuid);
                System.Console.WriteLine("Address ID: " + outObject.SubjectPropertyAddress.AddressId);
                System.Console.WriteLine("Borrower ID: " + outObject.Borrower.BorrowerId);
                System.Console.WriteLine("CoBorrower ID: " + outObject.CoBorrower?.BorrowerId);

                outObject.LoanInformation.ForEach(loanInformation => System.Console.WriteLine("BlitzDocs Folder ID: " + loanInformation.BlitzdocFolderId));
                outObject.LeadDates.ForEach(leadDate => System.Console.WriteLine(leadDate));
            }
        }
    }
}
