
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold172m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold172m";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 171.99017d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Iridium168() } },

        };
    }
}
    
    