using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium250";
        public override double halfLife { get; } = 1860.0d;
        public override double atomicWeight { get; } = 250.07952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8576847.4), new Californium246() } },
            { 6.9e-05d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    