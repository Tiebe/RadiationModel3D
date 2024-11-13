
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium182 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium182";
        public override double halfLife { get; } = 231120.0d;
        public override double atomicWeight { get; } = 181.95121d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten182() } },

        };
    }
}
    
    