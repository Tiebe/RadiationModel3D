using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine191 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine191";
        public override double halfLife { get; } = 0.0021d;
        public override double atomicWeight { get; } = 191.00415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8842047.4), new Bismuth187() } },

        };
    }
}
    
    