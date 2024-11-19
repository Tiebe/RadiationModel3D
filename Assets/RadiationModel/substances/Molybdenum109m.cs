using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum109m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum109m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 108.92851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01771, 70000.0), new Molybdenum109() } },

        };
    }
}
    
    