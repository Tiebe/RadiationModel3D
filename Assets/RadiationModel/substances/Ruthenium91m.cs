
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium91m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium91m";
        public override double halfLife { get; } = 7.6d;
        public override double atomicWeight { get; } = 90.92638d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium91() } },

        };
    }
}
    
    