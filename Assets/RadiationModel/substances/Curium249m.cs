using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Curium249m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 249.07601d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6218502.09), new Plutonium245() } },

        };
    }
}
    
    