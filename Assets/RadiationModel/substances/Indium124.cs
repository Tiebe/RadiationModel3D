using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium124";
        public override double halfLife { get; } = 3.12d;
        public override double atomicWeight { get; } = 123.91318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7361500.0), new Tin124() } },

        };
    }
}
    
    