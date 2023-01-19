using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeStation.Constants
{
    public class Constants
    {
        public const string KEY = "KEY";
        public const string APPLEPAY = "APPLEPAY";
        public const string ANDROIDPAY = "ANDROIDPAY";
        public const string TRANSITCARD = "TRANSITCARD";
        public const string ACCOUNTNUMBER = "ACCOUNTNUMBER";
        public const string PHONE = "PHONE";

        public enum rental_methods { KEY, APPLEPAY, ANDROIDPAY, TRANSITCARD , ACCOUNTNUMBER, PHONE }
      }
}
