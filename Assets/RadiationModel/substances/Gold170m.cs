using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold170m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold170m";
        public override double halfLife { get; } = 0.00062d;
        public override double atomicWeight { get; } = 169.99633d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.58d, new List<RadioactiveSubstance> { new ProtonParticle(), new Platinum169() } },
            { 0.42d, new List<RadioactiveSubstance> { new AlphaParticle(8485047.4), new Iridium166() } },

        };
    }
}
    
    