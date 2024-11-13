
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum118 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum118";
        public override double halfLife { get; } = 0.021d;
        public override double atomicWeight { get; } = 117.96525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium118() } },

        };
    }
}
    
    