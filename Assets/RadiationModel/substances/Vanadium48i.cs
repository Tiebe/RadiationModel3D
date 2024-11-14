using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium48i : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium48i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 47.95549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00041), new Vanadium48() } },

        };
    }
}
    
    