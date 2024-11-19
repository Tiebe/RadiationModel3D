using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium144n : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium144n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 143.92182d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00014, 8596100.0), new Promethium144() } },

        };
    }
}
    
    