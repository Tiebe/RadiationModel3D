using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium196m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium196m";
        public override double halfLife { get; } = 5040.0d;
        public override double atomicWeight { get; } = 195.96862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3417500.0), new Platinum196() } },

        };
    }
}
    
    