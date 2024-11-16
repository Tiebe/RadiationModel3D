using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium171";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 170.96318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.018000000000000002d, new List<RadioactiveSubstance> { new AlphaParticle(6391047.4), new Tungsten167() } },

        };
    }
}
    
    