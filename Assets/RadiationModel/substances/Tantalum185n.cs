using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum185n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum185n";
        public override double halfLife { get; } = 0.0118d;
        public override double atomicWeight { get; } = 184.95693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1273000.0, 0.00097)), new Tantalum185() } },

        };
    }
}
    
    