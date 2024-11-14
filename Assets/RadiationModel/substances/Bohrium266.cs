using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium266";
        public override double halfLife { get; } = 10.6d;
        public override double atomicWeight { get; } = 266.12679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10445047.4), new Dubnium262() } },

        };
    }
}
    
    