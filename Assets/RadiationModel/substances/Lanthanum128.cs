using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum128 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum128";
        public override double halfLife { get; } = 310.8d;
        public override double atomicWeight { get; } = 127.91559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6739200.0), new Barium128() } },

        };
    }
}
    
    