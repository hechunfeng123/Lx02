using System;

namespace Model
{
    public class UserInfo
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public string qq { get; set; }
        public string email { get; set; }
        public string type { get; set; }
        public string userImg { get; set; }
    }
    public class UserInfoNo : UserInfo {
        public int num { get; set; }
    }
    public class page {
        public  int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}
