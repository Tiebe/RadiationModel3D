using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine196 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196";
        public override double halfLife { get; } = 0.377d;
        public override double atomicWeight { get; } = 195.9958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new List<RadioactiveSubstance> { new AlphaParticle(8217002.09), new Bismuth192() } },

        };
    }
}
    
    