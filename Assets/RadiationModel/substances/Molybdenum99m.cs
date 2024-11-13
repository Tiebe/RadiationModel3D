
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum99m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum99m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 98.90781d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Molybdenum99() } },

        };
    }
}
    
    