using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium211";
        public override double halfLife { get; } = 81.0d;
        public override double atomicWeight { get; } = 210.99347d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4413000.0), new Lead211() } },

        };
    }
}
    
    