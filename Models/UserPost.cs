using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpclient.Models
{
    public class UserPost
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public static List<UserPost> userPosts = new List<UserPost>(){
            new UserPost(){id=1,body="deneme",title="deneme",userId=10},
            new UserPost(){id=2,body="deneme2",title="deneme2",userId=10},
            new UserPost(){id=3,body="deneme3",title="deneme3",userId=10},
            new UserPost(){id=4,body="deneme4",title="deneme4",userId=10}
        };




    }
}