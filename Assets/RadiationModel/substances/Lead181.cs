using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead181 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead181";
        public override double halfLife { get; } = 0.039d;
        public override double atomicWeight { get; } = 180.99666d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8265047.399999999), new Mercury177() } },

        };
    }
}
    
    