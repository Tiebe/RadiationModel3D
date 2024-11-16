using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium227";
        public override double halfLife { get; } = 2532.0d;
        public override double atomicWeight { get; } = 227.02918d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1328000.0), new Actinium227() } },

        };
    }
}
    
    