using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium165";
        public override double halfLife { get; } = 11.6d;
        public override double atomicWeight { get; } = 164.93932d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4063000.0), new Terbium165() } },

        };
    }
}
    
    