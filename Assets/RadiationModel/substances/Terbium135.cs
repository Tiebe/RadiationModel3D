using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium135";
        public override double halfLife { get; } = 0.00101d;
        public override double atomicWeight { get; } = 134.96452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Gadolinium134() } },

        };
    }
}
    
    