
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium141m";
        public override double halfLife { get; } = 7.9d;
        public override double atomicWeight { get; } = 140.94145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium141() } },

        };
    }
}
    
    