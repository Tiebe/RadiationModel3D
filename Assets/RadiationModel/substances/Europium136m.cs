using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium136m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium136m";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 135.93973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10671000.0), new Samarium136() } },

        };
    }
}
    
    