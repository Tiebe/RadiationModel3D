
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus34 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus34";
        public override double halfLife { get; } = 12.43d;
        public override double atomicWeight { get; } = 33.97365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sulfur34() } },

        };
    }
}
    
    