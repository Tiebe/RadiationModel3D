using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium124m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium124m";
        public override double halfLife { get; } = 3.67d;
        public override double atomicWeight { get; } = 123.91316d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7341500.0), new Tin124() } },

        };
    }
}
    
    