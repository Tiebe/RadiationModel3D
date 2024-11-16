using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium243";
        public override double halfLife { get; } = 0.231d;
        public override double atomicWeight { get; } = 243.07442d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new List<RadioactiveSubstance> { new AlphaParticle(9717002.09), new Californium239() } },
            { 0.09d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    