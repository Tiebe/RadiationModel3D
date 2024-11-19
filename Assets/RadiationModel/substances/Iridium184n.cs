using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium184n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium184n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 183.95783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00378, 328000.0), new Iridium184() } },

        };
    }
}
    
    