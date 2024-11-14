using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt55 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt55";
        public override double halfLife { get; } = 63108.0d;
        public override double atomicWeight { get; } = 54.942d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3451400.0), new Iron55() } },

        };
    }
}
    
    