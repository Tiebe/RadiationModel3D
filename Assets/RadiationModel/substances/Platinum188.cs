using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum188 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum188";
        public override double halfLife { get; } = 877824.0d;
        public override double atomicWeight { get; } = 187.9594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Iridium188() } },
            { 2.6e-07d, new List<RadioactiveSubstance> { new AlphaParticle(5026647.399999999), new Osmium184() } },

        };
    }
}
    
    