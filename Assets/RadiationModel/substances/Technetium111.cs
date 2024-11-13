
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium111";
        public override double halfLife { get; } = 0.35d;
        public override double atomicWeight { get; } = 110.9259d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium111() } },

        };
    }
}
    
    