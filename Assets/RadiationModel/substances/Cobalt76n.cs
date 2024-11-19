using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt76n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt76n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.97325d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00168, 740000.0), new Cobalt76() } },

        };
    }
}
    
    