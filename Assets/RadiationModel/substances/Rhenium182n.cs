using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium182n : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium182n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 181.95153d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((300000.0, 0.00413)), new Rhenium182() } },

        };
    }
}
    
    