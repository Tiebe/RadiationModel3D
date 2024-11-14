using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium64";
        public override double halfLife { get; } = 63.7d;
        public override double atomicWeight { get; } = 63.94169d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4516800.0), new Gallium64() } },

        };
    }
}
    
    