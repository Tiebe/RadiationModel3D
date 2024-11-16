using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum167 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum167";
        public override double halfLife { get; } = 79.8d;
        public override double atomicWeight { get; } = 166.94809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5117000.0), new Hafnium167() } },

        };
    }
}
    
    