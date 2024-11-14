using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium246";
        public override double halfLife { get; } = 0.92d;
        public override double atomicWeight { get; } = 246.08172d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9915047.4), new Einsteinium242() } },

        };
    }
}
    
    