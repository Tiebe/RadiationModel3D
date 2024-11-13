
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium89 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium89";
        public override double halfLife { get; } = 12.8d;
        public override double atomicWeight { get; } = 88.92765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum89() } },

        };
    }
}
    
    