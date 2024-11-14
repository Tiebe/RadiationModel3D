using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium225";
        public override double halfLife { get; } = 525.0d;
        public override double atomicWeight { get; } = 225.02395d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(7941047.4), new Radium221() } },

        };
    }
}
    
    