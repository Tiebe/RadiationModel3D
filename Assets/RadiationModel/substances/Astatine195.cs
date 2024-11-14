using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine195 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine195";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 194.99627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8364047.399999999), new Bismuth191() } },

        };
    }
}
    
    