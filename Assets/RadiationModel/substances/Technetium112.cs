using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium112";
        public override double halfLife { get; } = 0.323d;
        public override double atomicWeight { get; } = 111.92994d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10372000.0), new Ruthenium112() } },

        };
    }
}
    
    