
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium121";
        public override double halfLife { get; } = 0.022d;
        public override double atomicWeight { get; } = 120.96614d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium121() } },

        };
    }
}
    
    