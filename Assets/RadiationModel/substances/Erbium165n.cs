using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium165n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium165n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 164.93269d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00068, 1823000.0), new Erbium165() } },

        };
    }
}
    
    