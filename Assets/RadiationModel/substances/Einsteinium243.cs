using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium243";
        public override double halfLife { get; } = 22.1d;
        public override double atomicWeight { get; } = 243.06951d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.61d, new List<RadioactiveSubstance> { new AlphaParticle(9095047.4), new Berkelium239() } },
            { 0.01d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    