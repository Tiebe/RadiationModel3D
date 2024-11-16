using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium274 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium274";
        public override double halfLife { get; } = 57.0d;
        public override double atomicWeight { get; } = 274.1436d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9957002.09), new Dubnium270() } },

        };
    }
}
    
    