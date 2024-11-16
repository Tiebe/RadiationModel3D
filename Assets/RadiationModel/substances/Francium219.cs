using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium219";
        public override double halfLife { get; } = 0.0225d;
        public override double atomicWeight { get; } = 219.00925d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8469047.4), new Astatine215() } },

        };
    }
}
    
    