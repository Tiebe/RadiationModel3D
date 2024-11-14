using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium237 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium237";
        public override double halfLife { get; } = 0.8d;
        public override double atomicWeight { get; } = 237.0622d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(9245047.4), new Curium233() } },
            { 0.3d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    