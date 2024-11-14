using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium130n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130n";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 129.92537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10611100.0), new Tin130() } },

        };
    }
}
    
    