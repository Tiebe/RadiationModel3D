using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium191n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium191n";
        public override double halfLife { get; } = 5.7d;
        public override double atomicWeight { get; } = 190.96285d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2101000.0, 0.00059)), new Iridium191() } },

        };
    }
}
    
    