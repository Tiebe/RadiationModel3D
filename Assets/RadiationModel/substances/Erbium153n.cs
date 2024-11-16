using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium153n : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium153n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 152.94072d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00024), new Erbium153() } },

        };
    }
}
    
    