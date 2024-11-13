
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium102m";
        public override double halfLife { get; } = 261.0d;
        public override double atomicWeight { get; } = 101.90926d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium102() } },

        };
    }
}
    
    