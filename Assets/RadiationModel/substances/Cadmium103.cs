
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium103";
        public override double halfLife { get; } = 438.0d;
        public override double atomicWeight { get; } = 102.91342d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver103() } },

        };
    }
}
    
    