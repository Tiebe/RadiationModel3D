
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium118";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 117.95353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium118() } },

        };
    }
}
    
    