using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium278";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 278.15649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10607002.09), new Bohrium274() } },

        };
    }
}
    
    