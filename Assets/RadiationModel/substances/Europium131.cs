
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium131";
        public override double halfLife { get; } = 0.0178d;
        public override double atomicWeight { get; } = 130.95764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.89d, new List<RadioactiveSubstance> { new ProtonParticle(), new Samarium130() } },

        };
    }
}
    
    