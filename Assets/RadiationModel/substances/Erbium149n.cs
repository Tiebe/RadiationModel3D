using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium149n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium149n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 148.94511d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00047), new Erbium149() } },

        };
    }
}
    
    