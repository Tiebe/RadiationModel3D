using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium121m";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 120.91319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4976100.0), new Indium121() } },

        };
    }
}
    
    