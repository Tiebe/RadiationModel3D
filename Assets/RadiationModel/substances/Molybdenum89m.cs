
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum89m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum89m";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 88.91988d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Molybdenum89() } },

        };
    }
}
    
    