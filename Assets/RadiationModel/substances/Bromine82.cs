using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine82 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine82";
        public override double halfLife { get; } = 127015.2d;
        public override double atomicWeight { get; } = 81.9168d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3093095.0), new Krypton82() } },

        };
    }
}
    
    