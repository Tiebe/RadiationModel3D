using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine122 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine122";
        public override double halfLife { get; } = 217.8d;
        public override double atomicWeight { get; } = 121.90759d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony122() }, { 1.0d, new BetaParticle(1, 1127600.0) }, { 0.18d, new GammaParticle(564119.0, 0.0022) }, { 0.0002502d, new GammaParticle(617340.0, 0.00201) }, { 0.007956d, new GammaParticle(683647.0, 0.00181) }, { 0.013554d, new GammaParticle(692794.0, 0.00179) }, { 0.013266d, new GammaParticle(793278.0, 0.00156) }, { 8.28e-05d, new GammaParticle(945780.0, 0.00131) }, { 0.0001548d, new GammaParticle(953370.0, 0.0013) }, { 8.82e-05d, new GammaParticle(1004300.0, 0.00123) }, { 0.0001224d, new GammaParticle(1129710.0, 0.0011) }, { 0.0003564d, new GammaParticle(1183000.0, 0.00105) }, { 0.000261d, new GammaParticle(1188760.0, 0.00104) }, { 0.0028079999999999997d, new GammaParticle(1256901.0, 0.00099) }, { 0.0001638d, new GammaParticle(1337010.0, 0.00093) }, { 0.000135d, new GammaParticle(1356940.0, 0.00091) }, { 0.0003798d, new GammaParticle(1376400.0, 0.0009) }, { 0.0015876000000000002d, new GammaParticle(1499500.0, 0.00083) }, { 0.0006443999999999999d, new GammaParticle(1535080.0, 0.00081) }, { 9.54e-05d, new GammaParticle(1640170.0, 0.00076) }, { 0.0003798d, new GammaParticle(1723290.0, 0.00072) }, { 0.0002142d, new GammaParticle(1733640.0, 0.00072) }, { 0.00333d, new GammaParticle(1746930.0, 0.00071) }, { 0.0005454d, new GammaParticle(1752770.0, 0.00071) }, { 0.0001026d, new GammaParticle(1795090.0, 0.00069) }, { 0.0010188d, new GammaParticle(1843830.0, 0.00067) }, { 6.3e-05d, new GammaParticle(1897700.0, 0.00065) }, { 7.74e-05d, new GammaParticle(1936100.0, 0.00064) }, { 0.0003996d, new GammaParticle(1944380.0, 0.00064) }, { 0.0003348d, new GammaParticle(2029710.0, 0.00061) }, { 0.000297d, new GammaParticle(2155150.0, 0.00058) }, { 0.002664d, new GammaParticle(2192290.0, 0.00057) }, { 0.0001512d, new GammaParticle(2226590.0, 0.00056) }, { 0.0001098d, new GammaParticle(2232740.0, 0.00056) }, { 5.58e-05d, new GammaParticle(2287500.0, 0.00054) }, { 5.0400000000000005e-05d, new GammaParticle(2310800.0, 0.00054) }, { 5.58e-05d, new GammaParticle(2334400.0, 0.00053) }, { 0.0001728d, new GammaParticle(2346870.0, 0.00053) }, { 0.00018180000000000003d, new GammaParticle(2480740.0, 0.0005) }, { 9.900000000000001e-05d, new GammaParticle(2488020.0, 0.0005) }, { 0.0004374d, new GammaParticle(2585470.0, 0.00048) }, { 3.6e-05d, new GammaParticle(2593200.0, 0.00048) }, { 0.0002664d, new GammaParticle(2719270.0, 0.00046) }, { 0.000117d, new GammaParticle(2738440.0, 0.00045) }, { 0.00016199999999999998d, new GammaParticle(2919250.0, 0.00042) }, { 8.460000000000001e-05d, new GammaParticle(2982640.0, 0.00042) }, { 5.7600000000000004e-05d, new GammaParticle(3044810.0, 0.00041) }, { 5.7600000000000004e-05d, new GammaParticle(3208030.0, 0.00039) }, { 4.14e-05d, new GammaParticle(3288970.0, 0.00038) }, { 1.5630338000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.01695067503739549d, new GammaParticle(4135.0, 0.29984) }, { 0.04676215230806797d, new GammaParticle(27202.0, 0.04558) }, { 0.0870803581155828d, new GammaParticle(27473.0, 0.04513) }, { 0.02492088156285888d, new GammaParticle(31093.0, 0.03988) }, { 0.03032871286199926d, new GammaParticle(31359.0, 0.03954) }, { 0.005407831299140377d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    