using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium224";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 224.02764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9650002.09), new Thorium220() } },

        };
    }
}
    
    