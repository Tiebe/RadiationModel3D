using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium238";
        public override double halfLife { get; } = 0.0211d;
        public override double atomicWeight { get; } = 238.06149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new List<RadioactiveSubstance> {  } },
            { 0.025d, new List<RadioactiveSubstance> { new AlphaParticle(9155002.09), new Curium234() } },

        };
    }
}
    
    