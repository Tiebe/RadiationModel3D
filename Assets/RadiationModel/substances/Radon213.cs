using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon213 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon213";
        public override double halfLife { get; } = 0.0195d;
        public override double atomicWeight { get; } = 212.99389d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9265047.4), new Polonium209() } },

        };
    }
}
    
    