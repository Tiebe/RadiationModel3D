
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium97";
        public override double halfLife { get; } = 0.1691d;
        public override double atomicWeight { get; } = 96.93718d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Strontium97() } },

        };
    }
}
    
    