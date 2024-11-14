using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium131m";
        public override double halfLife { get; } = 116928.0d;
        public override double atomicWeight { get; } = 130.90872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.741d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2413940.0), new Iodine131() } },
            { 0.259d, new List<RadioactiveSubstance> { new GammaParticle(0.0068), new Tellurium131() } },

        };
    }
}
    
    