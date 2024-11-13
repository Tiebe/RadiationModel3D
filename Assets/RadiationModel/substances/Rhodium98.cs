
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium98";
        public override double halfLife { get; } = 523.2d;
        public override double atomicWeight { get; } = 97.91071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium98() } },

        };
    }
}
    
    