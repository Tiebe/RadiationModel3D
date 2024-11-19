using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine198m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine198m";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 197.99308d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new AlphaParticle(8178002.09), new Bismuth194() } },

        };
    }
}
    
    