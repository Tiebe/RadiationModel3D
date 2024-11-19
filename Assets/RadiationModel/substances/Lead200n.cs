using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead200n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead200n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 199.97505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00041, 3006000.0), new Lead200() } },

        };
    }
}
    
    