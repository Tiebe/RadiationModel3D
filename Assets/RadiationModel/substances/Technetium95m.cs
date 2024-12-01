using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium95m";
        public override double halfLife { get; } = 5270400.0d;
        public override double atomicWeight { get; } = 94.90769d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9612d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.632d, new GammaParticle(204117.0, 0.00607)), new(0.00042976d, new GammaParticle(218660.0, 0.00567)), new(1.7696e-05d, new GammaParticle(245830.0, 0.00504)), new(0.00610512d, new GammaParticle(253068.0, 0.0049)), new(1.264e-06d, new GammaParticle(263000.0, 0.00471)), new(5.5616e-05d, new GammaParticle(291670.0, 0.00425)), new(1.0112e-05d, new GammaParticle(318270.0, 0.0039)), new(3.16e-06d, new GammaParticle(515600.0, 0.0024)), new(9.48e-05d, new GammaParticle(563480.0, 0.0022)), new(0.2993784d, new GammaParticle(582082.0, 0.00213)), new(1.0112e-05d, new GammaParticle(589290.0, 0.0021)), new(0.012829600000000002d, new GammaParticle(616490.0, 0.00201)), new(5.6880000000000004e-05d, new GammaParticle(623290.0, 0.00199)), new(0.0865208d, new GammaParticle(786198.0, 0.00158)), new(1.4536e-05d, new GammaParticle(799600.0, 0.00155)), new(0.047084d, new GammaParticle(820624.0, 0.00151)), new(0.266072d, new GammaParticle(835149.0, 0.00148)), new(0.00011376000000000001d, new GammaParticle(844100.0, 0.00147)), new(0.00020856d, new GammaParticle(852600.0, 0.00145)), new(0.0277448d, new GammaParticle(1039264.0, 0.00119)), new(8.847999999999999e-05d, new GammaParticle(1056790.0, 0.00117)), new(1.896e-07d, new GammaParticle(1098000.0, 0.00113)), new(9.48e-07d, new GammaParticle(1165500.0, 0.00106)), new(8.342399999999999e-05d, new GammaParticle(1222000.0, 0.00101)), new(1.896e-07d, new GammaParticle(1302000.0, 0.00095)), new(1.3272e-06d, new GammaParticle(1369750.0, 0.00091)), new(1.8328e-05d, new GammaParticle(1416090.0, 0.00088)), new(2.528e-07d, new GammaParticle(1426110.0, 0.00087)), new(0.000381096d, new GammaParticle(1620200.0, 0.00077)), new(5.0560000000000004e-08d, new GammaParticle(1660270.0, 0.00075)), new(0.00886d, new GammaParticle(511000.0, 0.00243)), new(0.037486672435140665d, new GammaParticle(2440.0, 0.50813)), new(0.18780679469461137d, new GammaParticle(17374.0, 0.07136)), new(0.3579317604242641d, new GammaParticle(17479.0, 0.07093)), new(0.09391999744073543d, new GammaParticle(19681.0, 0.063)), new(0.10838367704660866d, new GammaParticle(19794.0, 0.06264)), new(0.014463679605873256d, new GammaParticle(19963.0, 0.06211)) } },
            { 0.0388d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium95()), new(7.499999999999999e-07d, new GammaParticle(38900.0, 0.03187)), new(0.0013694711160000001d, new GammaParticle(2586.0, 0.47944)), new(0.0019592976385230257d, new GammaParticle(18250.0, 0.06794)), new(0.003725608744101589d, new GammaParticle(18367.0, 0.0675)), new(0.0009901948336574998d, new GammaParticle(20695.0, 0.05991)), new(0.001146645617375385d, new GammaParticle(20820.0, 0.05955)), new(0.000156450783717885d, new GammaParticle(21003.0, 0.05903)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    