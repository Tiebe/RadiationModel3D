
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium137";
        public override double halfLife { get; } = 32400.0d;
        public override double atomicWeight { get; } = 136.90776d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum137() } },

        };
    }
}
    
    