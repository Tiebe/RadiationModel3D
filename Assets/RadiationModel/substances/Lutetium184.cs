using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium184 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium184";
        public override double halfLife { get; } = 20.0d;
        public override double atomicWeight { get; } = 183.96103d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5200000.0), new Hafnium184() } },

        };
    }
}
    
    