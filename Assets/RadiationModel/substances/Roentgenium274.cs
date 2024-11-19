using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium274";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 274.15525d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12497002.09), new Meitnerium270() } },

        };
    }
}
    
    