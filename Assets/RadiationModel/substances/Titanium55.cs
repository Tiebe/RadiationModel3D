using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium55";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 54.95509d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7293000.0), new Vanadium55() } },

        };
    }
}
    
    