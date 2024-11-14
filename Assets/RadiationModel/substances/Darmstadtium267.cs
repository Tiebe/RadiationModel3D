using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium267";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 267.14373d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12795047.4), new Hassium263() } },

        };
    }
}
    
    