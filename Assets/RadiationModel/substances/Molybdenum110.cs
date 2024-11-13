
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum110 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum110";
        public override double halfLife { get; } = 0.292d;
        public override double atomicWeight { get; } = 109.93072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium110() } },

        };
    }
}
    
    