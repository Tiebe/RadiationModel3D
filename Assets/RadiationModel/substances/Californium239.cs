using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium239";
        public override double halfLife { get; } = 28.0d;
        public override double atomicWeight { get; } = 239.06248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.65d, new List<RadioactiveSubstance> { new AlphaParticle(8787002.09), new Curium235() } },

        };
    }
}
    
    