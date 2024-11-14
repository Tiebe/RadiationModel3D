using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic70m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic70m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 69.93097d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.03875), new Arsenic70() } },

        };
    }
}
    
    