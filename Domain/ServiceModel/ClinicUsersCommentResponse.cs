using System.Collections.Generic;
using Domain.Entity;

namespace Domain.ServiceModel
{
    public class ClinicUsersCommentResponse
    {
        public IEnumerable<UsersComment> Comments { get; set; }
        public IDictionary<int, double> CommentPercentageByScore { get; set; }
        public int ReviewerCount { get; set; }
        public double? Score { get; set; }
    }
}