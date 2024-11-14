using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium257";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 257.10752d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.94d, new List<RadioactiveSubstance> { new AlphaParticle(10225047.4), new Lawrencium253() } },
            { 0.06d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    