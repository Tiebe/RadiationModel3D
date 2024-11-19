using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead194n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead194n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 193.97716d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00042, 2933000.0), new Lead194() } },

        };
    }
}
    
    