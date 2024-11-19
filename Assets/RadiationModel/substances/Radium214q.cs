using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium214q : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 214.00383d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00036, 3478000.0), new Radium214() } },

        };
    }
}
    
    