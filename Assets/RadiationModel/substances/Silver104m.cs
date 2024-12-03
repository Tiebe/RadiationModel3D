using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver104m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver104m";
        public override double halfLife { get; } = 2010.0d;
        public override double atomicWeight { get; } = 103.90863d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9993000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhodium104()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00108d, new GammaParticle(479200.0, 0.00259)), new(0.9d, new GammaParticle(555800.0, 0.00223)), new(0.009000000000000001d, new GammaParticle(767600.0, 0.00162)), new(0.0063d, new GammaParticle(777700.0, 0.00159)), new(0.0189d, new GammaParticle(785700.0, 0.00158)), new(0.0045000000000000005d, new GammaParticle(934600.0, 0.00133)), new(0.00017999999999999998d, new GammaParticle(974200.0, 0.00127)), new(0.0049499999999999995d, new GammaParticle(996100.0, 0.00124)), new(0.0017100000000000001d, new GammaParticle(1133100.0, 0.00109)), new(0.0018d, new GammaParticle(1191500.0, 0.00104)), new(0.0387d, new GammaParticle(1238800.0, 0.001)), new(0.00468d, new GammaParticle(1247200.0, 0.00099)), new(0.0045000000000000005d, new GammaParticle(1265200.0, 0.00098)), new(0.00819d, new GammaParticle(1297800.0, 0.00096)), new(0.016200000000000003d, new GammaParticle(1341800.0, 0.00092)), new(0.00045d, new GammaParticle(1354300.0, 0.00092)), new(0.00396d, new GammaParticle(1382400.0, 0.0009)), new(0.00297d, new GammaParticle(1418500.0, 0.00087)), new(0.0018d, new GammaParticle(1636100.0, 0.00076)), new(0.0027d, new GammaParticle(1637500.0, 0.00076)), new(0.0016200000000000001d, new GammaParticle(1652100.0, 0.00075)), new(0.009000000000000001d, new GammaParticle(1689500.0, 0.00073)), new(0.0171d, new GammaParticle(1720800.0, 0.00072)), new(0.00315d, new GammaParticle(1743100.0, 0.00071)), new(0.0207d, new GammaParticle(1781800.0, 0.0007)), new(0.004050000000000001d, new GammaParticle(1794600.0, 0.00069)), new(0.000126d, new GammaParticle(1869700.0, 0.00066)), new(0.00135d, new GammaParticle(1890600.0, 0.00066)), new(0.00189d, new GammaParticle(1900900.0, 0.00065)), new(0.00063d, new GammaParticle(1936100.0, 0.00064)), new(0.00198d, new GammaParticle(1965600.0, 0.00063)), new(0.00855d, new GammaParticle(1977500.0, 0.00063)), new(0.00063d, new GammaParticle(1992000.0, 0.00062)), new(0.00099d, new GammaParticle(1999100.0, 0.00062)), new(0.00711d, new GammaParticle(2015800.0, 0.00062)), new(0.0022500000000000003d, new GammaParticle(2065900.0, 0.0006)), new(0.00063d, new GammaParticle(2086800.0, 0.00059)), new(0.01575d, new GammaParticle(2139200.0, 0.00058)), new(0.0009d, new GammaParticle(2158900.0, 0.00057)), new(0.0009d, new GammaParticle(2215600.0, 0.00056)), new(0.00063d, new GammaParticle(2244600.0, 0.00055)), new(0.0009d, new GammaParticle(2254200.0, 0.00055)), new(0.024300000000000002d, new GammaParticle(2276700.0, 0.00054)), new(0.009000000000000001d, new GammaParticle(2338300.0, 0.00053)), new(0.0045000000000000005d, new GammaParticle(2362400.0, 0.00052)), new(0.0072d, new GammaParticle(2419600.0, 0.00051)), new(0.00054d, new GammaParticle(2437300.0, 0.00051)), new(0.00099d, new GammaParticle(2478300.0, 0.0005)), new(0.00855d, new GammaParticle(2522700.0, 0.00049)), new(0.00045d, new GammaParticle(2557400.0, 0.00048)), new(0.009000000000000001d, new GammaParticle(2626900.0, 0.00047)), new(0.00315d, new GammaParticle(2657500.0, 0.00047)), new(0.00135d, new GammaParticle(2705300.0, 0.00046)), new(0.011699999999999999d, new GammaParticle(2729500.0, 0.00045)), new(0.00054d, new GammaParticle(2777900.0, 0.00045)), new(0.00315d, new GammaParticle(2852500.0, 0.00043)), new(0.0018d, new GammaParticle(2918800.0, 0.00042)), new(0.0008100000000000001d, new GammaParticle(3008300.0, 0.00041)), new(0.0022500000000000003d, new GammaParticle(3034000.0, 0.00041)), new(0.00017999999999999998d, new GammaParticle(3097800.0, 0.0004)), new(0.00021600000000000002d, new GammaParticle(3116500.0, 0.0004)), new(0.0144d, new GammaParticle(3213600.0, 0.00039)), new(0.0144d, new GammaParticle(3407800.0, 0.00036)), new(0.00099d, new GammaParticle(3473900.0, 0.00036)), new(0.00027d, new GammaParticle(3647800.0, 0.00034)), new(0.000144d, new GammaParticle(4009000.0, 0.00031)), new(1.2583246d, new GammaParticle(511000.0, 0.00243)), new(0.019776325178304d, new GammaParticle(3053.0, 0.40611)), new(0.07860026762494496d, new GammaParticle(21020.0, 0.05898)), new(0.14849852186840157d, new GammaParticle(21177.0, 0.05855)), new(0.04074191103816533d, new GammaParticle(23904.0, 0.05187)), new(0.047668035914653434d, new GammaParticle(24070.0, 0.05151)), new(0.006926124876488106d, new GammaParticle(24297.0, 0.05103)) } },
            { 0.0007000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver104()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    