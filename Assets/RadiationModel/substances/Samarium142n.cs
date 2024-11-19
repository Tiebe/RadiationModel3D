using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium142n : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium142n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 141.91914d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3662200.0, 0.00034)), new Samarium142() } },

        };
    }
}
    
    