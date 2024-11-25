using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum135 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum135";
        public override double halfLife { get; } = 70200.0d;
        public override double atomicWeight { get; } = 134.90698d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cesium135() }, { 1.0d, new BetaParticle(1, 469500.0) }, { 1.0335999999999999e-05d, new GammaParticle(107320.0, 0.01155) }, { 1.52e-06d, new GammaParticle(124890.0, 0.00993) }, { 0.00054112d, new GammaParticle(220940.0, 0.00561) }, { 6.08e-07d, new GammaParticle(236680.0, 0.00524) }, { 6.08e-07d, new GammaParticle(242120.0, 0.00512) }, { 4.408e-05d, new GammaParticle(259580.0, 0.00478) }, { 3.04e-06d, new GammaParticle(267170.0, 0.00464) }, { 0.00031919999999999995d, new GammaParticle(366840.0, 0.00338) }, { 0.00018392d, new GammaParticle(374460.0, 0.00331) }, { 1.8239999999999998e-06d, new GammaParticle(392080.0, 0.00316) }, { 4.256e-05d, new GammaParticle(394040.0, 0.00315) }, { 2.5839999999999997e-06d, new GammaParticle(420120.0, 0.00295) }, { 0.0152d, new GammaParticle(480510.0, 0.00258) }, { 1.8239999999999998e-06d, new GammaParticle(499360.0, 0.00248) }, { 0.00110808d, new GammaParticle(587830.0, 0.00211) }, { 0.00020672d, new GammaParticle(634050.0, 0.00196) }, { 7.6e-07d, new GammaParticle(653830.0, 0.0019) }, { 6.992e-06d, new GammaParticle(758940.0, 0.00163) }, { 1.0639999999999999e-06d, new GammaParticle(787900.0, 0.00157) }, { 0.00018848d, new GammaParticle(855000.0, 0.00145) }, { 0.0016416d, new GammaParticle(874510.0, 0.00142) }, { 2.28e-06d, new GammaParticle(909630.0, 0.00136) }, { 5.168e-05d, new GammaParticle(979980.0, 0.00127) }, { 1.672e-07d, new GammaParticle(1008400.0, 0.00123) }, { 3.6479999999999996e-06d, new GammaParticle(1130890.0, 0.0011) }, { 7.6e-06d, new GammaParticle(1173890.0, 0.00106) }, { 0.00014000000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.096d, new GammaParticle(4966.0, 0.24967) }, { 0.21660000000000001d, new GammaParticle(31816.0, 0.03897) }, { 0.39899999999999997d, new GammaParticle(32193.0, 0.03851) }, { 0.1174d, new GammaParticle(36482.0, 0.03399) }, { 0.147d, new GammaParticle(36827.0, 0.03367) }, { 0.0296d, new GammaParticle(37255.0, 0.03328) } } },

        };
    }
}
    