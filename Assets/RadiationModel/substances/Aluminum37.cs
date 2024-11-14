using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum37 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum37";
        public override double halfLife { get; } = 0.0114d;
        public override double atomicWeight { get; } = 37.01053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 16380000.0), new Silicon37() } },

        };
    }
}
    
    