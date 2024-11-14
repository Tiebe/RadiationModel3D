using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum177p : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177p";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 176.94594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00092), new Tantalum177() } },

        };
    }
}
    
    