
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium95";
        public override double halfLife { get; } = 3023222.4d;
        public override double atomicWeight { get; } = 94.90683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum95() } },

        };
    }
}
    
    