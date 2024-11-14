using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium98";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 97.94213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 13730000.0), new Cadmium98() } },

        };
    }
}
    
    