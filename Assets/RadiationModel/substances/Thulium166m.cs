using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium166m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium166m";
        public override double halfLife { get; } = 0.348d;
        public override double atomicWeight { get; } = 165.93369d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01016, 122000.0), new Thulium166() } },

        };
    }
}
    
    