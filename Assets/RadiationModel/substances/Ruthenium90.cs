using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium90";
        public override double halfLife { get; } = 11.7d;
        public override double atomicWeight { get; } = 89.93034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5840700.0), new Technetium90() } },

        };
    }
}
    
    