using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium171";
        public override double halfLife { get; } = 43560.0d;
        public override double atomicWeight { get; } = 170.94049d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2397500.0), new Lutetium171() } },

        };
    }
}
    
    