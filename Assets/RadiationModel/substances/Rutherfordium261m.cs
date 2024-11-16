using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rutherfordium261m : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium261m";
        public override double halfLife { get; } = 74.0d;
        public override double atomicWeight { get; } = 261.10885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9738047.4), new Nobelium257() } },

        };
    }
}
    
    