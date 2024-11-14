using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon25 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon25";
        public override double halfLife { get; } = 0.2206d;
        public override double atomicWeight { get; } = 25.00411d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12742970.0), new Aluminum25() } },

        };
    }
}
    
    