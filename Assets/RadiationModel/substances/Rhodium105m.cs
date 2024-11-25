using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium105m";
        public override double halfLife { get; } = 42.8d;
        public override double atomicWeight { get; } = 104.90583d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium105() }, { 0.2024d, new GammaParticle(129782.0, 0.00955) }, { 0.036521667d, new GammaParticle(2892.0, 0.42871) }, { 0.11928744192785093d, new GammaParticle(20073.0, 0.06177) }, { 0.22583764090846448d, new GammaParticle(20215.0, 0.06133) }, { 0.06132926000315999d, new GammaParticle(22806.0, 0.05436) }, { 0.07150991716368454d, new GammaParticle(22957.0, 0.05401) }, { 0.010180657160524558d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    