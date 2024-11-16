using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium189";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 188.99847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8714047.4), new Lead185() } },

        };
    }
}
    
    