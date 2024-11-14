using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium276 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium276";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 276.1517d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11115047.4), new Bohrium272() } },

        };
    }
}
    
    