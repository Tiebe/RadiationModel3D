using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium154";
        public override double halfLife { get; } = 94670856000000.0d;
        public override double atomicWeight { get; } = 153.92443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3965047.4), new Gadolinium150() } },

        };
    }
}
    
    