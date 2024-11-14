using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum140 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum140";
        public override double halfLife { get; } = 145040.4d;
        public override double atomicWeight { get; } = 139.90949d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3762100.0), new Cerium140() } },

        };
    }
}
    
    