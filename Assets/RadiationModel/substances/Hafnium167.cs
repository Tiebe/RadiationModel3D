using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium167";
        public override double halfLife { get; } = 123.0d;
        public override double atomicWeight { get; } = 166.9426d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4062000.0), new Lutetium167() } },

        };
    }
}
    
    