using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium148";
        public override double halfLife { get; } = 3600.0d;
        public override double atomicWeight { get; } = 147.92428d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5732400.0), new Gadolinium148() } },

        };
    }
}
    
    