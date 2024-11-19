using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium212 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium212";
        public override double halfLife { get; } = 0.0058d;
        public override double atomicWeight { get; } = 212.02319d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9437002.09), new Actinium208() } },

        };
    }
}
    
    