using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin127 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin127";
        public override double halfLife { get; } = 7560.0d;
        public override double atomicWeight { get; } = 126.91039d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3228000.0), new Antimony127() } },

        };
    }
}
    
    