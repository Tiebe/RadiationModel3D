using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium195m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium195m";
        public override double halfLife { get; } = 1.92d;
        public override double atomicWeight { get; } = 194.98823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7920002.09), new Lead191() } },

        };
    }
}
    
    