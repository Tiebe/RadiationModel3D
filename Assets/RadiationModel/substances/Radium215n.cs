using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium215n : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 215.00513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00055, 2247000.0), new Radium215() } },

        };
    }
}
    
    