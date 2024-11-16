using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium189n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium189n";
        public override double halfLife { get; } = 0.00022d;
        public override double atomicWeight { get; } = 188.96113d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0007), new Rhenium189() } },

        };
    }
}
    
    