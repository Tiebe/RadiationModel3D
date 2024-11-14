using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum181n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum181n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 180.94866d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00202), new Tantalum181() } },

        };
    }
}
    
    