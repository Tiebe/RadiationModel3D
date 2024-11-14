using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium146m";
        public override double halfLife { get; } = 0.073d;
        public override double atomicWeight { get; } = 145.96699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Erbium145() } },

        };
    }
}
    
    