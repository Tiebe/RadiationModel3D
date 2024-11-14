using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium227";
        public override double halfLife { get; } = 148.2d;
        public override double atomicWeight { get; } = 227.03186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2504500.0), new Radium227() } },

        };
    }
}
    
    