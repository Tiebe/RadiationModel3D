using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium139m";
        public override double halfLife { get; } = 0.18d;
        public override double atomicWeight { get; } = 138.917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00656), new Promethium139() } },

        };
    }
}
    
    