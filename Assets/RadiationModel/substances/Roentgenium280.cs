using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium280";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 280.16521d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11175047.4), new Meitnerium276() } },

        };
    }
}
    
    