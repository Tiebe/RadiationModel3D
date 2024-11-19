using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon199 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon199";
        public override double halfLife { get; } = 0.59d;
        public override double atomicWeight { get; } = 198.99833d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8154002.09), new Polonium195() } },

        };
    }
}
    
    