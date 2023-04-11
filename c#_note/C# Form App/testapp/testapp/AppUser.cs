using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class AppUser
    {
        public int _id;
        public int id
        {
            get {
                 return _id;
                }
            set {

                 _id = value;
                if(_id<0)
                {
                       System.Windows.Forms.MessageBox.Show("0 -ээс их байх хэрэгтэй");
                }
                    
            }
        }
        public int UserTypeID { get; set; }
        public string _Uname;
        public string UserName
        {
            get
            {
                return _Uname;
            }
            set
            {
                _Uname = value;
                if (_Uname.Length > 25)
                {
                    System.Windows.Forms.MessageBox.Show("5 тэмдэгтээс хэтрэхгүй");
                }
            }
        }
        public string UserPassword { get; set; }
        public string UserInfo { get; set; }
        public byte[] UserImage { get; set; }
        public DateTime CDate { get; set; }
        public DateTime MDate { get; set; }
    }
}
