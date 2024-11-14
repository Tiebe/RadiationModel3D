using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium218";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 218.00758d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9033047.4), new Astatine214() } },

        };
    }
}
    
    