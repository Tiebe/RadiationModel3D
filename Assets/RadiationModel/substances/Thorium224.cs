using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium224";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 224.02147d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8321002.09), new Radium220() } },

        };
    }
}
    
    