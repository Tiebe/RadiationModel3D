using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Germanium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium81m";
        public override double halfLife { get; } = 7.6d;
        public override double atomicWeight { get; } = 80.92956d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic81()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.2482d, new GammaParticle(93100.0, 0.01332)), new(0.11972d, new GammaParticle(197300.0, 0.00628)), new(0.00511d, new GammaParticle(242840.0, 0.00511)), new(0.06278d, new GammaParticle(290350.0, 0.00427)), new(0.1241d, new GammaParticle(335980.0, 0.00369)), new(0.041609999999999994d, new GammaParticle(401750.0, 0.00309)), new(0.01752d, new GammaParticle(456300.0, 0.00272)), new(0.01387d, new GammaParticle(463100.0, 0.00268)), new(0.024820000000000002d, new GammaParticle(467980.0, 0.00265)), new(0.01387d, new GammaParticle(609100.0, 0.00204)), new(0.0219d, new GammaParticle(665900.0, 0.00186)), new(0.0073d, new GammaParticle(706070.0, 0.00176)), new(0.10220000000000001d, new GammaParticle(737740.0, 0.00168)), new(0.0073d, new GammaParticle(751510.0, 0.00165)), new(0.05402d, new GammaParticle(758500.0, 0.00163)), new(0.04453d, new GammaParticle(771260.0, 0.00161)), new(0.01168d, new GammaParticle(1005700.0, 0.00123)), new(0.012410000000000001d, new GammaParticle(1038500.0, 0.00119)), new(0.03066d, new GammaParticle(1056500.0, 0.00117)), new(0.0219d, new GammaParticle(1095500.0, 0.00113)), new(0.02993d, new GammaParticle(1225800.0, 0.00101)), new(0.01752d, new GammaParticle(1238900.0, 0.001)), new(0.00803d, new GammaParticle(1256100.0, 0.00099)), new(0.02044d, new GammaParticle(1297400.0, 0.00096)), new(0.032850000000000004d, new GammaParticle(1435700.0, 0.00086)), new(0.00803d, new GammaParticle(1686500.0, 0.00074)), new(0.0219d, new GammaParticle(1869800.0, 0.00066)), new(0.0146d, new GammaParticle(1869800.0, 0.00066)), new(0.019710000000000002d, new GammaParticle(2103900.0, 0.00059)), new(0.06278d, new GammaParticle(2174320.0, 0.00057)), new(0.032850000000000004d, new GammaParticle(2331300.0, 0.00053)), new(0.024820000000000002d, new GammaParticle(2377400.0, 0.00052)), new(0.0073d, new GammaParticle(2436600.0, 0.00051)), new(0.02847d, new GammaParticle(2526500.0, 0.00049)), new(0.032850000000000004d, new GammaParticle(2754800.0, 0.00045)), new(0.041609999999999994d, new GammaParticle(2800200.0, 0.00044)), new(0.02044d, new GammaParticle(2845800.0, 0.00044)), new(0.0073d, new GammaParticle(2859100.0, 0.00043)), new(0.01314d, new GammaParticle(2904700.0, 0.00043)), new(0.012410000000000001d, new GammaParticle(3136600.0, 0.0004)), new(0.03869d, new GammaParticle(3195100.0, 0.00039)), new(0.01095d, new GammaParticle(3195100.0, 0.00039)), new(0.02117d, new GammaParticle(3469500.0, 0.00036)), new(0.039420000000000004d, new GammaParticle(3562700.0, 0.00035)), new(0.0007754891396999999d, new GammaParticle(1320.0, 0.93927)), new(0.0062532068930684186d, new GammaParticle(10509.0, 0.11798)), new(0.012135080328097065d, new GammaParticle(10544.0, 0.11759)), new(0.0027747213131957167d, new GammaParticle(11773.0, 0.10531)), new(0.0028796057788345146d, new GammaParticle(11791.0, 0.10515)), new(0.00010488446563879809d, new GammaParticle(11861.0, 0.10453)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    