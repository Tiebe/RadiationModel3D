using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium81";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 80.92883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6241600.0), new Arsenic81() } },

        };
    }
}
    
    