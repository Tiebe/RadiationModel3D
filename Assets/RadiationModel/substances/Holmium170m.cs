using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium170m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 169.93973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3967500.0), new Erbium170() } },

        };
    }
}
    
    