
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum90m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum90m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 89.91702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Molybdenum90() } },

        };
    }
}
    
    