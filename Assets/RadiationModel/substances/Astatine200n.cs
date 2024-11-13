
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200n";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 199.99072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.105d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth196() } },

        };
    }
}
    
    