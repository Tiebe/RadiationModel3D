using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium244";
        public override double halfLife { get; } = 1170.0d;
        public override double atomicWeight { get; } = 244.066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(8350902.09), new Curium240() } },
            { 0.25d, new List<RadioactiveSubstance> { new Berkelium244() } },

        };
    }
}
    
    