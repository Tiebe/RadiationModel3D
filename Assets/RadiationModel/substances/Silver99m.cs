using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver99m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver99m";
        public override double halfLife { get; } = 10.5d;
        public override double atomicWeight { get; } = 98.91819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((506000.0, 0.00245)), new Silver99() } },

        };
    }
}
    
    