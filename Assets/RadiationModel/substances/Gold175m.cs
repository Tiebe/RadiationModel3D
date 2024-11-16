using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold175m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold175m";
        public override double halfLife { get; } = 0.136d;
        public override double atomicWeight { get; } = 174.98149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(7765047.4), new Iridium171() } },

        };
    }
}
    
    