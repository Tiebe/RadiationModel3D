using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 115.90526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3276220.0), new Tin116() } },
            { 0.000237d, new List<RadioactiveSubstance> { new Cadmium116() } },

        };
    }
}
    
    