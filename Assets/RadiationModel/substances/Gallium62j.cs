using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium62j : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium62j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 61.9448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00217, 571200.0), new Gallium62() } },

        };
    }
}
    
    