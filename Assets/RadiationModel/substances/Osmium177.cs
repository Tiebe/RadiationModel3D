using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium177";
        public override double halfLife { get; } = 180.0d;
        public override double atomicWeight { get; } = 176.95496d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4313000.0), new Rhenium177() } },

        };
    }
}
    
    