using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon222 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon222";
        public override double halfLife { get; } = 330177.6d;
        public override double atomicWeight { get; } = 222.01758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6610347.399999999), new Polonium218() } },

        };
    }
}
    
    