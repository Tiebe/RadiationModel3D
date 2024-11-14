using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine199 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine199";
        public override double halfLife { get; } = 7.02d;
        public override double atomicWeight { get; } = 198.99053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(7798047.4), new Bismuth195() } },

        };
    }
}
    
    