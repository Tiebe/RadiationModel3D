using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium236";
        public override double halfLife { get; } = 90189694.43538d;
        public override double atomicWeight { get; } = 236.04606d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium232() }, { 1.0d, new AlphaParticle(6889102.09) }, { 0.00065d, new GammaParticle(47570.0, 0.02606) }, { 0.000225d, new GammaParticle(108950.0, 0.01138) }, { 7.35e-06d, new GammaParticle(166090.0, 0.00746) }, { 8.4e-08d, new GammaParticle(218000.0, 0.00569) }, { 7.2e-08d, new GammaParticle(338500.0, 0.00366) }, { 1.0900000000000001e-07d, new GammaParticle(364000.0, 0.00341) }, { 5.4999999999999996e-08d, new GammaParticle(404460.0, 0.00307) }, { 6.3e-09d, new GammaParticle(423850.0, 0.00293) }, { 2.5000000000000002e-08d, new GammaParticle(472340.0, 0.00262) }, { 1.63e-06d, new GammaParticle(515580.0, 0.0024) }, { 1.14e-06d, new GammaParticle(563190.0, 0.0022) }, { 1.2e-08d, new GammaParticle(577950.0, 0.00215) }, { 4.0999999999999997e-08d, new GammaParticle(581410.0, 0.00213) }, { 1.8e-08d, new GammaParticle(590280.0, 0.0021) }, { 2.25e-06d, new GammaParticle(643870.0, 0.00193) }, { 9.5e-10d, new GammaParticle(677000.0, 0.00183) }, { 2.3e-08d, new GammaParticle(687040.0, 0.0018) }, { 3.2e-09d, new GammaParticle(710100.0, 0.00175) }, { 3.0800000000000004e-08d, new GammaParticle(734550.0, 0.00169) }, { 9.4e-09d, new GammaParticle(811260.0, 0.00153) }, { 6.000000000000001e-08d, new GammaParticle(819270.0, 0.00151) }, { 4.8999999999999995e-08d, new GammaParticle(866880.0, 0.00143) }, { 2.1e-08d, new GammaParticle(879900.0, 0.00141) }, { 9.6e-09d, new GammaParticle(920230.0, 0.00135) }, { 3.6e-09d, new GammaParticle(927690.0, 0.00134) }, { 3.5e-09d, new GammaParticle(967900.0, 0.00128) }, { 0.11189904217831033d, new GammaParticle(16678.0, 0.07434) }, { 4.562284452869442e-07d, new GammaParticle(94657.0, 0.0131) }, { 7.303160641699123e-07d, new GammaParticle(98439.0, 0.0126) }, { 2.634800773607625e-07d, new GammaParticle(111238.0, 0.01115) }, { 3.535902638181433e-07d, new GammaParticle(112645.0, 0.01101) }, { 9.011018645738076e-08d, new GammaParticle(114446.0, 0.01083) } } },
            { 1.9e-09d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    