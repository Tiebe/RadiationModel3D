
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine24 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine24";
        public override double halfLife { get; } = 0.384d;
        public override double atomicWeight { get; } = 24.00809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon24() } },

        };
    }
}
    
    