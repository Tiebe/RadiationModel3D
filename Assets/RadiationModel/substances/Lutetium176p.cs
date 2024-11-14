using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium176p : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium176p";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 175.9444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00078), new Lutetium176() } },

        };
    }
}
    
    