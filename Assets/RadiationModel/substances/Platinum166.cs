using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum166 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum166";
        public override double halfLife { get; } = 0.00029d;
        public override double atomicWeight { get; } = 165.99487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8315047.399999999), new Osmium162() } },

        };
    }
}
    
    