using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton92 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton92";
        public override double halfLife { get; } = 1.84d;
        public override double atomicWeight { get; } = 91.92617d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6002700.0), new Rubidium92() } },

        };
    }
}
    
    