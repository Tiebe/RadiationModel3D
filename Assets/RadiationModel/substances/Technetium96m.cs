using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium96m";
        public override double halfLife { get; } = 3090.0d;
        public override double atomicWeight { get; } = 95.9079d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.98d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium96()), new(0.000259d, new GammaParticle(34200.0, 0.03625)), new(0.03658423951d, new GammaParticle(2586.0, 0.47944)), new(0.09816897543016409d, new GammaParticle(18250.0, 0.06794)), new(0.1866685214492567d, new GammaParticle(18367.0, 0.0675)), new(0.049612886978047645d, new GammaParticle(20695.0, 0.05991)), new(0.057451723120579175d, new GammaParticle(20820.0, 0.05955)), new(0.007838836142531528d, new GammaParticle(21003.0, 0.05903)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium96()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(5.999999999999999e-06d, new GammaParticle(218500.0, 0.00567)), new(7.5e-05d, new GammaParticle(241400.0, 0.00514)), new(1.7e-05d, new GammaParticle(269800.0, 0.0046)), new(0.00057d, new GammaParticle(350320.0, 0.00354)), new(0.0005600000000000001d, new GammaParticle(352500.0, 0.00352)), new(2.6e-05d, new GammaParticle(371500.0, 0.00334)), new(5.1000000000000006e-05d, new GammaParticle(374900.0, 0.00331)), new(2.8e-05d, new GammaParticle(460000.0, 0.0027)), new(0.0031d, new GammaParticle(480700.0, 0.00258)), new(1.7e-05d, new GammaParticle(544400.0, 0.00228)), new(2.6e-05d, new GammaParticle(568800.0, 0.00218)), new(0.00067d, new GammaParticle(615900.0, 0.00201)), new(5.6e-05d, new GammaParticle(647300.0, 0.00192)), new(0.003d, new GammaParticle(719550.0, 0.00172)), new(0.019d, new GammaParticle(778220.0, 0.00159)), new(1.9e-05d, new GammaParticle(810300.0, 0.00153)), new(0.0012d, new GammaParticle(847600.0, 0.00146)), new(0.0028000000000000004d, new GammaParticle(849850.0, 0.00146)), new(4.7000000000000004e-05d, new GammaParticle(853000.0, 0.00145)), new(0.00045d, new GammaParticle(966400.0, 0.00128)), new(0.0008100000000000001d, new GammaParticle(968500.0, 0.00128)), new(2.1e-05d, new GammaParticle(983200.0, 0.00126)), new(1.9e-05d, new GammaParticle(985700.0, 0.00126)), new(0.0006d, new GammaParticle(1091300.0, 0.00114)), new(0.0007199999999999999d, new GammaParticle(1096580.0, 0.00113)), new(3.7e-06d, new GammaParticle(1107500.0, 0.00112)), new(3.7e-06d, new GammaParticle(1109800.0, 0.00112)), new(1.1000000000000001e-05d, new GammaParticle(1124000.0, 0.0011)), new(1.9e-05d, new GammaParticle(1173300.0, 0.00106)), new(0.011000000000000001d, new GammaParticle(1200150.0, 0.00103)), new(0.00013d, new GammaParticle(1237800.0, 0.001)), new(1.7e-05d, new GammaParticle(1317400.0, 0.00094)), new(0.0012d, new GammaParticle(1497650.0, 0.00083)), new(1.1000000000000001e-05d, new GammaParticle(1620600.0, 0.00077)), new(0.00012d, new GammaParticle(1625800.0, 0.00076)), new(1.9e-05d, new GammaParticle(1702500.0, 0.00073)), new(0.00039d, new GammaParticle(1815600.0, 0.00068)), new(4.4999999999999996e-05d, new GammaParticle(1846200.0, 0.00067)), new(8.999999999999999e-05d, new GammaParticle(1957100.0, 0.00063)), new(2.3999999999999997e-05d, new GammaParticle(511000.0, 0.00243)), new(0.0007642453383913208d, new GammaParticle(2440.0, 0.50813)), new(0.003828658520791719d, new GammaParticle(17374.0, 0.07136)), new(0.007296852526761424d, new GammaParticle(17479.0, 0.07093)), new(0.0019146676724818496d, new GammaParticle(19681.0, 0.063)), new(0.002209526494044054d, new GammaParticle(19794.0, 0.06264)), new(0.0002948588215622048d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    