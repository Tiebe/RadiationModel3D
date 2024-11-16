using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium272 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium272";
        public override double halfLife { get; } = 11.3d;
        public override double atomicWeight { get; } = 272.13826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10325047.4), new Dubnium268() } },

        };
    }
}
    
    