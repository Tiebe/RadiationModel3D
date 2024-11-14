using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon46 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon46";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 45.96804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5642600.0), new Potassium46() } },

        };
    }
}
    
    