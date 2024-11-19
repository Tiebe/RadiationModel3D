using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt52i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt52i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 51.96627d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new GammaParticle((2924000.0, 0.00042)), new Cobalt52() } },

        };
    }
}
    
    