using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold173 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173";
        public override double halfLife { get; } = 0.0255d;
        public override double atomicWeight { get; } = 172.98622d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new AlphaParticle(7858002.09), new Iridium169() } },

        };
    }
}
    
    