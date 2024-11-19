using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine191m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine191m";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 191.00421d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8902002.09), new Bismuth187() } },

        };
    }
}
    
    