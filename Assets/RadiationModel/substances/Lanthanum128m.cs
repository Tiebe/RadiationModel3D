
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum128m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum128m";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 127.91569d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium128() } },

        };
    }
}
    
    