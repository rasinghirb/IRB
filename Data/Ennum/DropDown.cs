using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace IRB.Data.Ennum
{
    public class DropDown
    { }
    public enum rank
    {
        Commandant = 1,
        DyComdt = 2,
        AC = 3,
        MO = 4,
        InspExe = 5,
        InspWL = 6,
        SIExe = 7,
        SIWL = 8,
        SIPham = 9,
        ASI = 10,
        Steno = 11,
        HCExe = 12,
        HCWL = 13,
        LDC = 14,
        CTExe = 15,
        CTWL = 16,
        Cook = 17,
        WM = 18,
        WC = 19,
        Barber = 20,
        Swpr = 21,
        HeadClrk = 22,
        NursingAsst = 23,
    }
    public enum coy
    {
        ACoy = 1,
        BCoy = 2,
        CCoy = 3,
        DCoy = 4,
        ECoy = 5,
        FCoy = 6,
        GCoy = 7,
        WL = 8,
        RHQ = 9,
        HQ = 10,
        MT = 11,
    }
    public enum martialStatus
    {
        Married = 1,
        Unmarried = 2,
        Widow = 3,
        Widower = 4,
    }
    public enum patelat
    {
        DNH = 1,
        Daman = 2,
        Diu = 3,
        Androth = 4,
        Amini = 5,
        Agatti = 6,
        Kavaratti = 7,
        Kalpeni = 8,
        Kadmath = 9,
        Kiltan = 10,
        Chetlath = 11,
        Minicoy = 12,
        Kochi = 13,
        Other14,
    }
    public enum placeOfPosting
    {
        RHQSilvassa = 1,
        Daman = 2,
        Diu = 3,
        Kochi = 4,
        Kavaratti = 5,
        Agathi = 6,
        Androth = 7,
        Amini = 8,
        Kalpeni = 9,
        Kadmath = 10,
        Kiltan = 11,
        Chetlath = 12,
        Minicoy = 13,
        NewDelhi = 14,
    }
    public enum relationShip
    {
        Wife = 1,
        Son = 2,
        Daughter = 3,
        Father = 4,
        Mother = 5,
        Brother = 6,
        Friend = 7,
        Others = 8,
    }
    public enum state
    {
        DNH =1,
        Lakshadweep =3,
        Maharashtra =4,
        UP =5,
        Bihar =6,
        Rajsthan =7,
        Delhi =8,
        Gujrat =9,
        Kerla =10,
        HimachalPradesh =11,
        Haryana =12,
        Odisa =13,
        Karntka =14,
        AndhraPradesh =15,
        WestBengal =16,
        AndharPradesh =17,
        Telangna =18,
        Karnatka =19,
        Assam =20,
        Jharkhand =21,
        Utrakhand =22,
        TamilNadu =23,
        Pondichery =24,
        Punjab =25,
        Chandigarh =26,
        JK =27,
        Laddakh =28,
        Nagaland =29,
        Mizoram =30,
        Arunachalpradesh =31,
        Manipur =32,
        Meghalya =33,
        Sikkim =34,
    }
    public enum bloodGroup
    {
        APositive=1,
        ANegative=2,
        BPositive = 3,
        BNegative = 4,
        OPositive = 5,
        ONegative = 6,
        ABPositive =7,
        ABNegative = 8,
    }
    public enum education
    {
        Matric =1,
        HSC =2,
        Graduation =3,
        PostGraduate =4,
    }
    public enum religion
    {
        Hindu =1,
        Islam =2,
        Sikh =3,
        Christine =3,
        Budhism =4,
        Jain =5,
        Other =6,
    }
    public enum category
    {
        SC =1,
        ST =2,
        OBC =3,
        General =4,
    }
    public enum leaveType
    {
        EL = 1,
        CL = 2,
        HPL = 3,
        EOL = 4,
        LWP = 5,
        ELHPL =6,
       ELPL = 7,
        ELEOL = 8,
        ELLWP = 9,
        PL = 10,
       Other = 11,
       
    }
}
