using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium237";
        public override double halfLife { get; } = 3943296.0d;
        public override double atomicWeight { get; } = 237.04841d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999958d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium237() }, { 0.0022140000000000003d, new GammaParticle(26344.6, 0.04706) }, { 0.0007445599999999999d, new GammaParticle(33196.0, 0.03735) }, { 2.9520000000000002e-05d, new GammaParticle(42704.0, 0.02903) }, { 3.936e-05d, new GammaParticle(43420.0, 0.02855) }, { 1.64e-05d, new GammaParticle(55560.0, 0.02232) }, { 0.032799999999999996d, new GammaParticle(59540.9, 0.02082) }, { 1.5744000000000001e-06d, new GammaParticle(69760.0, 0.01777) }, { 3.1488000000000002e-06d, new GammaParticle(75800.0, 0.01636) }, { 1.968e-05d, new GammaParticle(98970.0, 0.01253) }, { 1.0495999999999999e-05d, new GammaParticle(102980.0, 0.01204) }, { 3.28e-06d, new GammaParticle(125300.0, 0.00989) }, { 0.45799999999999996d, new GammaParticle(17136.0, 0.07235) }, { 0.129d, new GammaParticle(97078.0, 0.01277) }, { 0.205d, new GammaParticle(101068.0, 0.01227) }, { 0.0747d, new GammaParticle(114160.0, 0.01086) }, { 0.1d, new GammaParticle(115608.0, 0.01072) }, { 0.025699999999999997d, new GammaParticle(117470.0, 0.01055) } } },
            { 4.2e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium233() }, { 1.0d, new AlphaParticle(6769602.09) }, { 7.3e-08d, new GammaParticle(181800.0, 0.00682) }, { 6.7e-07d, new GammaParticle(198610.0, 0.00624) }, { 2.9e-07d, new GammaParticle(205050.0, 0.00605) }, { 3.3e-06d, new GammaParticle(228560.0, 0.00542) }, { 4.6e-08d, new GammaParticle(241000.0, 0.00514) }, { 1.47e-06d, new GammaParticle(258460.0, 0.0048) }, { 1.66e-06d, new GammaParticle(261660.0, 0.00474) }, { 9.2e-06d, new GammaParticle(280400.0, 0.00442) }, { 6.6e-06d, new GammaParticle(298890.0, 0.00415) }, { 2.7e-07d, new GammaParticle(305400.0, 0.00406) }, { 2.5e-06d, new GammaParticle(313340.0, 0.00396) }, { 5.500000000000001e-06d, new GammaParticle(320750.0, 0.00387) }, { 1.6e-07d, new GammaParticle(411100.0, 0.00302) }, { 3.1e-07d, new GammaParticle(463100.0, 0.00268) }, { 6.3e-07d, new GammaParticle(503900.0, 0.00246) }, { 7.3e-08d, new GammaParticle(521100.0, 0.00238) }, { 1.0519015122499999e-06d, new GammaParticle(16678.0, 0.07434) }, { 6.110502684486352e-07d, new GammaParticle(94657.0, 0.0131) }, { 9.781499414897314e-07d, new GammaParticle(98439.0, 0.0126) }, { 3.5289244602208137e-07d, new GammaParticle(111238.0, 0.01115) }, { 4.7358166256163327e-07d, new GammaParticle(112645.0, 0.01101) }, { 1.2068921653955183e-07d, new GammaParticle(114446.0, 0.01083) } } },

        };
    }
}
    