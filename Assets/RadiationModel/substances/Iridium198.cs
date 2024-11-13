
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium198";
        public override double halfLife { get; } = 8.7d;
        public override double atomicWeight { get; } = 197.9724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Platinum198() } },

        };
    }
}
    
    