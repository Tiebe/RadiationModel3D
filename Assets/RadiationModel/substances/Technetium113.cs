using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium113";
        public override double halfLife { get; } = 0.152d;
        public override double atomicWeight { get; } = 112.93257d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9058000.0), new Ruthenium113() } },

        };
    }
}
    
    