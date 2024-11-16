using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium242";
        public override double halfLife { get; } = 11833857000000.0d;
        public override double atomicWeight { get; } = 242.05874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6006202.09), new Uranium238() } },
            { 5.51e-06d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    