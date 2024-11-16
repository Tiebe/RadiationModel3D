using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium171";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 170.97165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.15d, new List<RadioactiveSubstance> { new AlphaParticle(7015047.4), new Rhenium167() } },

        };
    }
}
    
    