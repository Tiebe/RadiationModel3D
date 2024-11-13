
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium99";
        public override double halfLife { get; } = 17.0d;
        public override double atomicWeight { get; } = 98.92493d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver99() } },

        };
    }
}
    
    