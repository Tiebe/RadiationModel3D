using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony127 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony127";
        public override double halfLife { get; } = 332640.0d;
        public override double atomicWeight { get; } = 126.90693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1582500.0), new Tellurium127() } },

        };
    }
}
    
    