using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium163";
        public override double halfLife { get; } = 40.0d;
        public override double atomicWeight { get; } = 162.94711d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5522000.0), new Lutetium163() } },

        };
    }
}
    
    