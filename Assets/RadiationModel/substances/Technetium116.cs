
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium116";
        public override double halfLife { get; } = 0.057d;
        public override double atomicWeight { get; } = 115.94502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium116() } },

        };
    }
}
    
    