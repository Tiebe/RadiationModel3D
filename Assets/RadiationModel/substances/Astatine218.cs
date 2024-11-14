using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine218 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine218";
        public override double halfLife { get; } = 1.28d;
        public override double atomicWeight { get; } = 218.0087d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7896047.4), new Bismuth214() } },

        };
    }
}
    
    