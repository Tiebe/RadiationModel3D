
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium107";
        public override double halfLife { get; } = 0.286d;
        public override double atomicWeight { get; } = 106.93159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum107() } },

        };
    }
}
    
    