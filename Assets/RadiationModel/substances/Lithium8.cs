
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium8";
        public override double halfLife { get; } = 0.8387d;
        public override double atomicWeight { get; } = 8.02249d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Beryllium8() } },

        };
    }
}
    
    