using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium247";
        public override double halfLife { get; } = 31.0d;
        public override double atomicWeight { get; } = 247.07694d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new List<RadioactiveSubstance> { new AlphaParticle(9275047.4), new Californium243() } },

        };
    }
}
    
    