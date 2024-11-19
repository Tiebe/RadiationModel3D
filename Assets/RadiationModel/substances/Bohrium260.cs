using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium260 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium260";
        public override double halfLife { get; } = 0.041d;
        public override double atomicWeight { get; } = 260.12144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11417002.09), new Dubnium256() } },

        };
    }
}
    
    