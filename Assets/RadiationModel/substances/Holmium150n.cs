using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium150n : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium150n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 149.94197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00016, 7896000.0), new Holmium150() } },

        };
    }
}
    
    