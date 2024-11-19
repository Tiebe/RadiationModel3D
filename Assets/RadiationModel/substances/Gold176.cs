using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold176 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold176";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 175.98012d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.75d, new List<RadioactiveSubstance> { new AlphaParticle(7457002.09), new Iridium172() } },

        };
    }
}
    
    