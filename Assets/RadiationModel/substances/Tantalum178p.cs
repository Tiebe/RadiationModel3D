using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum178p : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum178p";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 177.94879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2900000.0, 0.00043)), new Tantalum178() } },

        };
    }
}
    
    