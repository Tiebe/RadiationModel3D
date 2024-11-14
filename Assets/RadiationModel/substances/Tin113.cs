using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin113 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin113";
        public override double halfLife { get; } = 9942912.0d;
        public override double atomicWeight { get; } = 112.90518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1039020.0), new Indium113() } },

        };
    }
}
    
    