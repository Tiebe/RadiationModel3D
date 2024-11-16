using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium261";
        public override double halfLife { get; } = 0.0128d;
        public override double atomicWeight { get; } = 261.1214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11525047.4), new Dubnium257() } },

        };
    }
}
    
    