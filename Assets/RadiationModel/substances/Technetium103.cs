using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium103";
        public override double halfLife { get; } = 54.2d;
        public override double atomicWeight { get; } = 102.90917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2663200.0), new Ruthenium103() } },

        };
    }
}
    
    