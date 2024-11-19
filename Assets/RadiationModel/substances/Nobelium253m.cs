using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 253.09074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9605002.09), new Fermium249() } },

        };
    }
}
    
    