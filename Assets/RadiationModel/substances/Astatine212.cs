using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine212 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine212";
        public override double halfLife { get; } = 0.314d;
        public override double atomicWeight { get; } = 211.99074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8837147.4), new Bismuth208() } },

        };
    }
}
    
    