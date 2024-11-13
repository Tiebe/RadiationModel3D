
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium11 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium11";
        public override double halfLife { get; } = 13.76d;
        public override double atomicWeight { get; } = 11.02166d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Boron11() } },

        };
    }
}
    
    