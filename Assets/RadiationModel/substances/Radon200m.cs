using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon200m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon200m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 199.9982d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2320000.0, 0.00053)), new Radon200() } },

        };
    }
}
    
    