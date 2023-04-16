using SimchaFund.Data;

namespace SimchaFund.Web.Models
{
    public class ContributionsViewModel
    {
        public Simcha CurrentSimcha { get; set; }
        public List<Contributor> Contributors { get; set; }
    }
}
