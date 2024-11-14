using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold173m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold173m";
        public override double halfLife { get; } = 0.0122d;
        public override double atomicWeight { get; } = 172.98645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(8070047.4), new Iridium169() } },

        };
    }
}
    
    