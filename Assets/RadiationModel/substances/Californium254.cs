using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium254";
        public override double halfLife { get; } = 5227200.0d;
        public override double atomicWeight { get; } = 254.08732d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9969d, new List<RadioactiveSubstance> {  } },
            { 0.0031d, new List<RadioactiveSubstance> { new AlphaParticle(6946047.4), new Curium250() } },

        };
    }
}
    
    