
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon110 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon110";
        public override double halfLife { get; } = 0.093d;
        public override double atomicWeight { get; } = 109.94426d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.64d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tellurium106() } },

            { 0.36d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine110() } },

        };
    }
}
    
    