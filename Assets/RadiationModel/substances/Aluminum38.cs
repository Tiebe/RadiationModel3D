using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum38 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum38";
        public override double halfLife { get; } = 0.009d;
        public override double atomicWeight { get; } = 38.01768d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 20640000.0), new Silicon38() } },

        };
    }
}
    
    