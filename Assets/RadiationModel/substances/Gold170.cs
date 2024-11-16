using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold170 : RadioactiveSubstance
    {
        public override string name { get; } = "Gold170";
        public override double halfLife { get; } = 0.00029d;
        public override double atomicWeight { get; } = 169.99603d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.89d, new List<RadioactiveSubstance> { new ProtonParticle(), new Platinum169() } },
            { 0.11d, new List<RadioactiveSubstance> { new AlphaParticle(8207002.09), new Iridium166() } },

        };
    }
}
    
    