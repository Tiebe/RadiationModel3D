using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium116m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium116m";
        public override double halfLife { get; } = 3257.4d;
        public override double atomicWeight { get; } = 115.9054d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3403490.0), new Tin116() } },

        };
    }
}
    
    