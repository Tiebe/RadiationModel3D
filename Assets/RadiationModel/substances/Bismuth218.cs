using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth218 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth218";
        public override double halfLife { get; } = 33.0d;
        public override double atomicWeight { get; } = 218.01419d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4859300.0), new Polonium218() } },

        };
    }
}
    
    