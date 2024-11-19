using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth188 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth188";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 187.99228d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8285002.09), new Thallium184() } },

        };
    }
}
    
    