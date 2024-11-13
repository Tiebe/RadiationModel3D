
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium115";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 114.91366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver115() } },

        };
    }
}
    
    