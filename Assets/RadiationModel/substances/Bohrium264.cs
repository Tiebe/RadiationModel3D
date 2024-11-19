using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium264";
        public override double halfLife { get; } = 1.07d;
        public override double atomicWeight { get; } = 264.12449d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new AlphaParticle(10887002.09), new Dubnium260() } },
            { 0.14d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    