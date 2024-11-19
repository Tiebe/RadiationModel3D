using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium201n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium201n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 201.00416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00428, 290000.0), new Francium201() } },

        };
    }
}
    
    