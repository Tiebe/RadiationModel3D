
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium160";
        public override double halfLife { get; } = 0.725d;
        public override double atomicWeight { get; } = 159.94322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium160() } },

        };
    }
}
    
    