
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum99 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum99";
        public override double halfLife { get; } = 237355.2d;
        public override double atomicWeight { get; } = 98.90771d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium99() } },

        };
    }
}
    
    