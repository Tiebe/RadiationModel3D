using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium214 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium214";
        public override double halfLife { get; } = 0.00551d;
        public override double atomicWeight { get; } = 213.99897d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9611002.09), new Astatine210() } },

        };
    }
}
    
    