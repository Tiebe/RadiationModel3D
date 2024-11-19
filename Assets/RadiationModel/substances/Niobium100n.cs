using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium100n : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 99.91471d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((347000.0, 0.00357)), new Niobium100() } },

        };
    }
}
    
    