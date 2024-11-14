using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158m";
        public override double halfLife { get; } = 0.036d;
        public override double atomicWeight { get; } = 157.96674d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new List<RadioactiveSubstance> { new AlphaParticle(7285047.4), new Lutetium154() } },

        };
    }
}
    
    