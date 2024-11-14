using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium177n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium177n";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 176.95042d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01459), new Rhenium177() } },

        };
    }
}
    
    