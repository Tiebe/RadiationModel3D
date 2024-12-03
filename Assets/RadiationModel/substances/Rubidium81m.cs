using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium81m";
        public override double halfLife { get; } = 1830.0d;
        public override double atomicWeight { get; } = 80.91909d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.976d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium81()), new(0.052199999999999996d, new GammaParticle(86260.0, 0.01437)), new(0.0226582191d, new GammaParticle(1767.0, 0.70166)), new(0.123673809837568d, new GammaParticle(13336.0, 0.09297)), new(0.23806315656894703d, new GammaParticle(13396.0, 0.09255)), new(0.057955707521043814d, new GammaParticle(15021.0, 0.08254)), new(0.06467856959348489d, new GammaParticle(15070.0, 0.08227)), new(0.006722862072441081d, new GammaParticle(15187.0, 0.08164)) } },
            { 0.024d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine81()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00726d, new GammaParticle(49500.0, 0.02505)), new(0.0001331d, new GammaParticle(190400.0, 0.00651)), new(1.1e-06d, new GammaParticle(266200.0, 0.00466)), new(0.00010120000000000001d, new GammaParticle(368300.0, 0.00337)), new(0.00019800000000000002d, new GammaParticle(446300.0, 0.00278)), new(8.14e-05d, new GammaParticle(456900.0, 0.00271)), new(0.00019800000000000002d, new GammaParticle(463300.0, 0.00268)), new(0.00019800000000000002d, new GammaParticle(465500.0, 0.00266)), new(0.000275d, new GammaParticle(499400.0, 0.00248)), new(0.00099d, new GammaParticle(548900.0, 0.00226)), new(5.4999999999999995e-05d, new GammaParticle(551500.0, 0.00225)), new(0.001078d, new GammaParticle(643600.0, 0.00193)), new(1.76e-05d, new GammaParticle(643600.0, 0.00193)), new(0.00012869999999999998d, new GammaParticle(657500.0, 0.00189)), new(0.00046199999999999995d, new GammaParticle(682300.0, 0.00182)), new(0.000308d, new GammaParticle(729200.0, 0.0017)), new(0.00019800000000000002d, new GammaParticle(732100.0, 0.00169)), new(8.800000000000001e-05d, new GammaParticle(761900.0, 0.00163)), new(0.000143d, new GammaParticle(824200.0, 0.0015)), new(8.47e-05d, new GammaParticle(873800.0, 0.00142)), new(0.0003597d, new GammaParticle(885000.0, 0.0014)), new(0.0003597d, new GammaParticle(932400.0, 0.00133)), new(0.0002739d, new GammaParticle(981600.0, 0.00126)), new(3.3e-05d, new GammaParticle(1011000.0, 0.00123)), new(0.0001133d, new GammaParticle(1014400.0, 0.00122)), new(0.0001122d, new GammaParticle(1087000.0, 0.00114)), new(0.0007062d, new GammaParticle(1099900.0, 0.00113)), new(3.96e-05d, new GammaParticle(1136000.0, 0.00109)), new(6.6e-05d, new GammaParticle(1157000.0, 0.00107)), new(0.001045d, new GammaParticle(1194600.0, 0.00104)), new(1.1000000000000001e-05d, new GammaParticle(1206000.0, 0.00103)), new(6.49e-05d, new GammaParticle(1286900.0, 0.00096)), new(6.93e-05d, new GammaParticle(1297000.0, 0.00096)), new(6.6e-05d, new GammaParticle(1633200.0, 0.00076)), new(0.0001188d, new GammaParticle(1638400.0, 0.00076)), new(0.00014409999999999998d, new GammaParticle(1682700.0, 0.00074)), new(0.0001001d, new GammaParticle(1687900.0, 0.00073)), new(0.00017160000000000002d, new GammaParticle(1694400.0, 0.00073)), new(1.1000000000000001e-05d, new GammaParticle(1732000.0, 0.00072)), new(0.0005324d, new GammaParticle(1743500.0, 0.00071)), new(5.17e-05d, new GammaParticle(1781800.0, 0.0007)), new(9.9e-06d, new GammaParticle(1853000.0, 0.00067)), new(4.51e-05d, new GammaParticle(1902600.0, 0.00065)), new(0.024123000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.00055d, new GammaParticle(1648.0, 0.75233)), new(0.0038d, new GammaParticle(12596.0, 0.09843)), new(0.0073d, new GammaParticle(12649.0, 0.09802)), new(0.0018d, new GammaParticle(14169.0, 0.0875)), new(0.0019d, new GammaParticle(14209.0, 0.08726)), new(0.00017999999999999998d, new GammaParticle(14313.0, 0.08662)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    