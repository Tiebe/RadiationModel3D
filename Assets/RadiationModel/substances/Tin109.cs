using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin109 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin109";
        public override double halfLife { get; } = 1086.0d;
        public override double atomicWeight { get; } = 108.91129d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3860000.0), new Indium109() } },

        };
    }
}
    
    