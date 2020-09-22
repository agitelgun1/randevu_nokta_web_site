using System.Collections.Generic;
using Domain.Entity;

namespace Domain.ServiceModel
{
    public class DoctorUsersCommentResponse
    {
        public IEnumerable<UsersComment> Comments { get; set; }
        public IDictionary<int, double> CommentPercentageByScore { get; set; }
    }
}