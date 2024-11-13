
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium137";
        public override double halfLife { get; } = 2.2d;
        public override double atomicWeight { get; } = 136.94502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Europium137() } },

        };
    }
}
    
    