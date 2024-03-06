using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_EnrolmentSystem
{
    public class Address
    {
        // constants
        const string DEF_STREETNUM = "N/A";
        const string DEF_STREET = "N/A";
        const string DEF_SUBURB = "N/A";
        const string DEF_POSTCODE = "N/A";
        const string DEF_STATE = "N/A";

        // variables
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        // Property Assessor methods
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // no-args constructor
        public Address() : this(DEF_STREETNUM, DEF_STREET, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        // all-args constructor
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        /// <summary>
        /// Overriding the ToString method
        /// </summary>
        /// <returns>The streetNum, streetName, suburb, postcode, and state</returns>
        public override string ToString()
        {
            return "street number: " + StreetNum + ", street name: " + StreetName + ", suburb: " + Suburb
                + ", postcode: " + postcode + ", state: " + State;
        }
    }
}
