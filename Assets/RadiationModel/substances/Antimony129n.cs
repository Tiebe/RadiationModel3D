using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony129n : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony129n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 128.91114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1861000.0, 0.00067)), new Antimony129() } },

        };
    }
}
    
    