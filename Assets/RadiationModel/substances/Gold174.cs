using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold174 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold174";
        public override double halfLife { get; } = 0.139d;
        public override double atomicWeight { get; } = 173.98491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(7717002.09), new Iridium170() } },

        };
    }
}
    
    