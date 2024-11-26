using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium158";
        public override double halfLife { get; } = 8244.0d;
        public override double atomicWeight { get; } = 157.92989d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Holmium158()), new(0.061d, new GammaParticle(7697.0, 0.16108)), new(0.001944d, new GammaParticle(24395.0, 0.05082)), new(0.001224d, new GammaParticle(25500.0, 0.04862)), new(0.00010080000000000001d, new GammaParticle(28660.0, 0.04326)), new(0.000144d, new GammaParticle(28700.0, 0.0432)), new(3.6e-05d, new GammaParticle(30600.0, 0.04052)), new(0.00021600000000000002d, new GammaParticle(30800.0, 0.04025)), new(0.001512d, new GammaParticle(43430.0, 0.02855)), new(0.004248d, new GammaParticle(43430.0, 0.02855)), new(0.00216d, new GammaParticle(45400.0, 0.02731)), new(0.00216d, new GammaParticle(50680.0, 0.02446)), new(0.000576d, new GammaParticle(50700.0, 0.02445)), new(0.00017999999999999998d, new GammaParticle(62200.0, 0.01993)), new(9.36e-05d, new GammaParticle(64890.0, 0.01911)), new(0.002088d, new GammaParticle(67200.0, 0.01845)), new(0.0005256d, new GammaParticle(69910.0, 0.01773)), new(0.10800000000000001d, new GammaParticle(71903.0, 0.01724)), new(0.0009647999999999999d, new GammaParticle(79603.0, 0.01558)), new(0.000468d, new GammaParticle(86300.0, 0.01437)), new(0.001692d, new GammaParticle(93680.0, 0.01323)), new(0.002016d, new GammaParticle(101340.0, 0.01223)), new(0.00036720000000000004d, new GammaParticle(107480.0, 0.01154)), new(0.0001656d, new GammaParticle(114170.0, 0.01086)), new(0.0016200000000000001d, new GammaParticle(115400.0, 0.01074)), new(0.0012959999999999998d, new GammaParticle(118630.0, 0.01045)), new(0.001368d, new GammaParticle(131650.0, 0.00942)), new(0.00020879999999999998d, new GammaParticle(162370.0, 0.00764)), new(0.000504d, new GammaParticle(162500.0, 0.00763)), new(0.0002736d, new GammaParticle(166890.0, 0.00743)), new(0.00017999999999999998d, new GammaParticle(189100.0, 0.00656)), new(0.00043200000000000004d, new GammaParticle(190200.0, 0.00652)), new(0.0144d, new GammaParticle(195420.0, 0.00634)), new(0.00043200000000000004d, new GammaParticle(200200.0, 0.00619)), new(0.00011520000000000001d, new GammaParticle(201500.0, 0.00615)), new(0.0017280000000000002d, new GammaParticle(204160.0, 0.00607)), new(0.0008928d, new GammaParticle(207890.0, 0.00596)), new(0.00042479999999999997d, new GammaParticle(212520.0, 0.00583)), new(0.00045359999999999997d, new GammaParticle(233500.0, 0.00531)), new(0.002448d, new GammaParticle(238860.0, 0.00519)), new(0.029304d, new GammaParticle(248580.0, 0.00499)), new(0.002088d, new GammaParticle(271450.0, 0.00457)), new(0.00040320000000000004d, new GammaParticle(276980.0, 0.00448)), new(0.0016344d, new GammaParticle(286400.0, 0.00433)), new(0.001152d, new GammaParticle(294190.0, 0.00421)), new(0.008064d, new GammaParticle(296070.0, 0.00419)), new(0.00023040000000000002d, new GammaParticle(307700.0, 0.00403)), new(0.018000000000000002d, new GammaParticle(310820.0, 0.00399)), new(0.002664d, new GammaParticle(314890.0, 0.00394)), new(0.0008640000000000001d, new GammaParticle(326000.0, 0.0038)), new(0.002664d, new GammaParticle(326700.0, 0.0038)), new(0.00043200000000000004d, new GammaParticle(328900.0, 0.00377)), new(0.001152d, new GammaParticle(336020.0, 0.00369)), new(0.01044d, new GammaParticle(341580.0, 0.00363)), new(0.019799999999999998d, new GammaParticle(358240.0, 0.00346)), new(0.0756d, new GammaParticle(386820.0, 0.00321)), new(0.0018d, new GammaParticle(394500.0, 0.00314)), new(0.0018d, new GammaParticle(425200.0, 0.00292)), new(0.000288d, new GammaParticle(425300.0, 0.00292)), new(0.007992d, new GammaParticle(472420.0, 0.00262)), new(0.00828d, new GammaParticle(515860.0, 0.0024)), new(0.001368d, new GammaParticle(536800.0, 0.00231)), new(0.0009288d, new GammaParticle(571000.0, 0.00217)), new(0.001152d, new GammaParticle(587900.0, 0.00211)), new(0.002304d, new GammaParticle(620500.0, 0.002)), new(0.00108d, new GammaParticle(620600.0, 0.002)), new(0.003096d, new GammaParticle(629200.0, 0.00197)), new(0.000252d, new GammaParticle(664000.0, 0.00187)), new(0.000576d, new GammaParticle(735600.0, 0.00169)), new(0.002232d, new GammaParticle(766200.0, 0.00162)), new(0.0004896d, new GammaParticle(790500.0, 0.00157)), new(0.003096d, new GammaParticle(826700.0, 0.0015)), new(0.48895826236904805d, new GammaParticle(7656.0, 0.16194)), new(0.3922034008432817d, new GammaParticle(46700.0, 0.02655)), new(0.6984922543958713d, new GammaParticle(47547.0, 0.02608)), new(0.2256701248578152d, new GammaParticle(53982.0, 0.02297)), new(0.2843443573208472d, new GammaParticle(54577.0, 0.02272)), new(0.05867423246303195d, new GammaParticle(55293.0, 0.02242)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    