
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium125";
        public override double halfLife { get; } = 9.7d;
        public override double atomicWeight { get; } = 124.92844d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum125() } },

        };
    }
}
    
    