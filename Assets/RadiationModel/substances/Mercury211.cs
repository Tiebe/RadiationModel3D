using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury211 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury211";
        public override double halfLife { get; } = 26.4d;
        public override double atomicWeight { get; } = 210.99958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5690000.0), new Thallium211() } },

        };
    }
}
    
    