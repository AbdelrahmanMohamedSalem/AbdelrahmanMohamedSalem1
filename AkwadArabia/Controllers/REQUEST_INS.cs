using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkwadArabia.Controllers
{
    public class REQUEST_INS
    {
        public int REQUEST_TYPE_ID { get; set; }
        public DateTime REQ_DATE { get; set; }
        public int BUILDING_ID { get; set; }
        public int DEPARTMENT_ID { get; set; }
        public string EMPLOYEE_NAME { get; set; }
        public string EMPLOYEE_MOBILE { get; set; }
        public string EMPLOYEE_PHONE { get; set; }
        public int CATEGORY_MASTER_ID { get; set; }
        public int CATEGORY_DETAIL_ID { get; set; }
        public string PLACE { get; set; }
        public string DESCREPTION { get; set; }
    }
}