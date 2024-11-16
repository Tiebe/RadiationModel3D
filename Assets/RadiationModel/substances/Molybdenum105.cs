using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum105 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum105";
        public override double halfLife { get; } = 36.3d;
        public override double atomicWeight { get; } = 104.91698d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4959000.0), new Technetium105() } },

        };
    }
}
    
    