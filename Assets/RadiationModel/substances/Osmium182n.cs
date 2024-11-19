using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium182n : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium182n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 181.95968d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00018, 7049000.0), new Osmium182() } },

        };
    }
}
    
    