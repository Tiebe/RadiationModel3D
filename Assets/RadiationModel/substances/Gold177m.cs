using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold177m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold177m";
        public override double halfLife { get; } = 1.193d;
        public override double atomicWeight { get; } = 176.97707d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new List<RadioactiveSubstance> { new AlphaParticle(7507047.4), new Iridium173() } },

        };
    }
}
    
    