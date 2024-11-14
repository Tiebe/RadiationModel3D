using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium210";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 210.01509d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9089047.4), new Radium206() } },

        };
    }
}
    
    