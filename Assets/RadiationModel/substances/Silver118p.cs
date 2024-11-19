using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver118p : RadioactiveSubstance
    {
        public override string name { get; } = "Silver118p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 117.9149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00444, 279400.0), new Silver118() } },

        };
    }
}
    
    