using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium281 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium281";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 281.16454d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> {  } },
            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(10485047.4), new Hassium277() } },

        };
    }
}
    
    