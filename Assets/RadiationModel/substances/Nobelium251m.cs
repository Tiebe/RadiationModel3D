using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium251m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium251m";
        public override double halfLife { get; } = 1.02d;
        public override double atomicWeight { get; } = 251.08906d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9887002.09), new Fermium247() } },

        };
    }
}
    
    