
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium107";
        public override double halfLife { get; } = 205120188000000.0d;
        public override double atomicWeight { get; } = 106.90513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silver107() } },

        };
    }
}
    
    