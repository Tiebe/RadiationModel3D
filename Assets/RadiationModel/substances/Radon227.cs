using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon227 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon227";
        public override double halfLife { get; } = 20.2d;
        public override double atomicWeight { get; } = 227.0353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3204000.0), new Francium227() } },

        };
    }
}
    
    