using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium127";
        public override double halfLife { get; } = 34.0d;
        public override double atomicWeight { get; } = 126.92273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5917000.0), new Lanthanum127() } },

        };
    }
}
    
    