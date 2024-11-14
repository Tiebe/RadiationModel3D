using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium245";
        public override double halfLife { get; } = 0.38d;
        public override double atomicWeight { get; } = 245.08087d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10035047.4), new Einsteinium241() } },

        };
    }
}
    
    