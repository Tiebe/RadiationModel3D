using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium286";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 286.17876d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9647002.09), new Meitnerium282() } },

        };
    }
}
    
    