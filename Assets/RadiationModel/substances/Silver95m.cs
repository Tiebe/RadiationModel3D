using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95m";
        public override double halfLife { get; } = 0.5d;
        public override double atomicWeight { get; } = 94.93605d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00365), new Silver95() } },

        };
    }
}
    
    