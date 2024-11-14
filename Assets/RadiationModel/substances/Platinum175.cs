using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum175 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum175";
        public override double halfLife { get; } = 2.43d;
        public override double atomicWeight { get; } = 174.9724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new List<RadioactiveSubstance> { new AlphaParticle(7183047.4), new Osmium171() } },

        };
    }
}
    
    