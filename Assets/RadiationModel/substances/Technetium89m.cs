
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium89m";
        public override double halfLife { get; } = 12.9d;
        public override double atomicWeight { get; } = 88.92772d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum89() } },

        };
    }
}
    
    