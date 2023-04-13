using System.ComponentModel;

namespace TT.Common.Enums
{
    public class Enums
    {
        
        public enum Role
        {
            [Description("Select One")]
            None = 0, 
            [Description("Admin")]
            Admin = 1,
            [Description("Associate")]
            Associate = 2,
        }

        public enum Sex
        {
            [Description("Select One")]
            None = 0,
            [Description("Male")]
            Male = 1,
            [Description("Female")]
            Female = 2,
            [Description("Unkown")]
            Unknown = 3
        }

        public enum AnimalType
        {
            [Description("Select One")]
            None = 0,
            [Description("Dog")]
            Dog = 1,
            [Description("Cat")]
            Cat = 2,
            [Description("Man of War")]
            Man_Of_War = 3,
        }

        public enum State
        {
            [Description("Select One")]
            None = 0,
            [Description("Alabama")]
            AL = 1,
            [Description("Alaska")]
            AK = 2,
            [Description("Arizona")]
            AZ = 3,
            [Description("Arkansas")]
            AR = 4,
            [Description("American Samoa")]
            AS = 5,
            [Description("California")]
            CA = 6,
            [Description("Colorado")]
            CO = 7,
            [Description("Connecticut")]
            CT = 8,
            [Description("Delaware")]
            DE = 9,
            [Description("Washington DC")]
            DC = 10,
            [Description("Florida")]
            FL = 11,
            [Description("Georgia")]
            GA = 12,
            [Description("Guam")]
            GU = 13,
            [Description("Hawaii")]
            HI = 14,
            [Description("Idaho")]
            ID = 15, 
            [Description("Illinios")]
            IL = 16, 
            [Description("Indiana")]
            IN = 17, 
            [Description("Iowa")]
            IA = 18, 
            [Description("Kansas")]
            KS = 19, 
            [Description("Kentucky")]
            KY = 20, 
            [Description("Louisiana")]
            LA = 21, 
            [Description("Maine")]
            ME = 22, 
            [Description("Maryland")]
            MD = 23, 
            [Description("Massachusetts")]
            MA = 24, 
            [Description("Michigan")]
            MI = 25, 
            [Description("Minnesota")]
            MN = 26, 
            [Description("Mississippi")]
            MS = 27, 
            [Description("Missouri")]
            MO = 28, 
            [Description("Montana")]
            MT = 29, 
            [Description("Nebraska")]
            NE = 30, 
            [Description("Nevada")]
            NV = 31, 
            [Description("New Hampshire")]
            NH = 32, 
            [Description("New Jersey")]
            NJ = 33, 
            [Description("New Mexico")]
            NM = 34, 
            [Description("New York")]
            NY = 35, 
            [Description("North Carolina")]
            NC = 36, 
            [Description("North Dakota")]
            ND = 37, 
            [Description("North Mariana Islands")]
            MP = 38, 
            [Description("Ohio")]
            OH = 39, 
            [Description("Oklahoma")]
            OK = 40, 
            [Description("Oregon")]
            OR = 41, 
            [Description("Pennsylvania")]
            PA = 42, 
            [Description("Puerto Rico")]
            PR = 43, 
            [Description("Rhode Island")]
            RI = 44, 
            [Description("South Carolina")]
            SC = 45, 
            [Description("South Dakota")]
            SD = 46, 
            [Description("Tennessee")]
            TN = 47, 
            [Description("Texas")]
            TX = 48, 
            [Description("Utah")]
            UT = 49, 
            [Description("Vermont")]
            VT = 50, 
            [Description("Virginia")]
            VA = 51, 
            [Description("US Virgin Islands")]
            VI = 52, 
            [Description("Washington")]
            WA = 53, 
            [Description("West Virginia")]
            WV = 54, 
            [Description("Wisconsin")]
            WI = 55, 
            [Description("Wyoming")]
            WY = 56, 
        }
    }
}
