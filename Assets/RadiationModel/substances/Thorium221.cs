using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium221";
        public override double halfLife { get; } = 0.00175d;
        public override double atomicWeight { get; } = 221.01819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9647002.09), new Radium217() } },

        };
    }
}
    
    