using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin103 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin103";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 102.92798d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7542000.0), new Indium103() } },

        };
    }
}
    
    