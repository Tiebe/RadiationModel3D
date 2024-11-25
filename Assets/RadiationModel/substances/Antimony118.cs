using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony118 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony118";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 117.90553d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium118() }, { 1.0d, new BetaParticle(1, -384000.0) }, { 0.004775d, new GammaParticle(528730.0, 0.00234) }, { 0.00015d, new GammaParticle(813200.0, 0.00152) }, { 0.004d, new GammaParticle(827340.0, 0.0015) }, { 0.0008d, new GammaParticle(1098500.0, 0.00113) }, { 0.000475d, new GammaParticle(1172900.0, 0.00106) }, { 0.025d, new GammaParticle(1229330.0, 0.00101) }, { 0.005175d, new GammaParticle(1267230.0, 0.00098) }, { 0.000225d, new GammaParticle(1447400.0, 0.00086) }, { 0.000775d, new GammaParticle(1699700.0, 0.00073) }, { 0.00045d, new GammaParticle(1907200.0, 0.00065) }, { 7.5e-05d, new GammaParticle(2044000.0, 0.00061) }, { 0.0001075d, new GammaParticle(2327000.0, 0.00053) }, { 0.000125d, new GammaParticle(2677500.0, 0.00046) }, { 1.4697214d, new GammaParticle(511000.0, 0.00243) }, { 0.017959349344847d, new GammaParticle(3753.0, 0.33036) }, { 0.056014753028251665d, new GammaParticle(25044.0, 0.04951) }, { 0.10483764369876786d, new GammaParticle(25271.0, 0.04906) }, { 0.029644142621537597d, new GammaParticle(28579.0, 0.04338) }, { 0.035484038717980504d, new GammaParticle(28810.0, 0.04304) }, { 0.005839896096442907d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    