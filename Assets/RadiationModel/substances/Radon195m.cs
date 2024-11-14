using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon195m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon195m";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 195.00551d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8795047.4), new Polonium191() } },

        };
    }
}
    
    