
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 196.96966d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum197() } },

        };
    }
}
    
    