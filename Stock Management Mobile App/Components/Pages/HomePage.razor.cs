using Stock_Management_Mobile_App.Components.Models;

namespace Stock_Management_Mobile_App.Components.Pages
{
    public partial class HomePage
    {
        List<String> listdates;
        List<Transaction> alltransactions;
        List<Transaction> sortedtransactions;
        String chosendate;
        public HomePage() 
        {
            listdates = [];
            chosendate = string.Empty;
            alltransactions = [];
            sortedtransactions = [];
        }

        private async Task AddDates()
        {
            listdates.Add("Today");
            listdates.Add("Yesterday");
            listdates.Add("Two Days Ago");
            listdates.Add("This Week");
            listdates.Add("Last Week");
            listdates.Add("Two Weeks Ago");
            listdates.Add("This Month");
            listdates.Add("Last Month");
        }

        protected override async Task OnInitializedAsync()
        {
            await AddDates();
            alltransactions = transactionservice.GetTransactions();
        }

        private void SortTransactions(String selecteddate)
        {
            DateTime firstday;
            DateTime lastday;
            chosendate = selecteddate;
            if (selecteddate.Equals("Today")) 
            {
                sortedtransactions = alltransactions.Where(item => item.CreatedDate.DayOfYear == DateTime.Today.DayOfYear).ToList();
                return;
            }
            else if (selecteddate.Equals("Yesterday"))
            {
                sortedtransactions = alltransactions.Where(item => item.CreatedDate.DayOfYear == DateTime.Today.AddDays(-1).DayOfYear).ToList();
                return;
            }
            else if (selecteddate.Equals("Two Days Ago"))
            {
                sortedtransactions = alltransactions.Where(item => item.CreatedDate.DayOfYear == DateTime.Today.AddDays(-2).DayOfYear).ToList();
                return;
            }
            else if(selecteddate.Equals("This Week"))
            {   firstday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                lastday = firstday.AddDays(6);
                sortedtransactions = alltransactions.Where(item => item.CreatedDate>=firstday && item.CreatedDate<=lastday).ToList();
                return;
            }
            else if (selecteddate.Equals("Last Week"))
            {
                firstday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                firstday = firstday.AddDays(-7);
                lastday = firstday.AddDays(6);
                sortedtransactions = alltransactions.Where(item => item.CreatedDate >= firstday && item.CreatedDate <= lastday).ToList();
                return;
            }
            else if (selecteddate.Equals("Two Week Ago"))
            {
                firstday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                firstday = firstday.AddDays(-14);
                lastday = firstday.AddDays(6);
                sortedtransactions = alltransactions.Where(item => item.CreatedDate >= firstday && item.CreatedDate <= lastday).ToList();
                return;
            }
            else if (selecteddate.Equals("This Month"))
            {
                sortedtransactions = alltransactions.Where(item => item.CreatedDate.Month == DateTime.Today.Month).ToList();
                return;
            }
            else if (selecteddate.Equals("Last Month"))
            {
                sortedtransactions = alltransactions.Where(item => item.CreatedDate.Month == DateTime.Today.AddMonths(-1).Month).ToList();
                return;
            }
        }
    }
}