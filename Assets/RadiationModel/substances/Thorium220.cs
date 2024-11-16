using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium220 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium220";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 220.01577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9996002.09), new Radium216() } },

        };
    }
}
    
    