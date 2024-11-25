using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon131m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon131m";
        public override double halfLife { get; } = 1022976.0d;
        public override double atomicWeight { get; } = 130.90526d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon131() }, { 0.0195d, new GammaParticle(163930.0, 0.00756) }, { 0.08266649429999999d, new GammaParticle(4540.0, 0.27309) }, { 0.1580752140235221d, new GammaParticle(29458.0, 0.04209) }, { 0.29284033720548736d, new GammaParticle(29778.0, 0.04164) }, { 0.08489324334222532d, new GammaParticle(33726.0, 0.03676) }, { 0.1049280487709905d, new GammaParticle(34030.0, 0.03643) }, { 0.020034805428765175d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    