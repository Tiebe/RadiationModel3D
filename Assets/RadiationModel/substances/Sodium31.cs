
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium31 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium31";
        public override double halfLife { get; } = 0.0168d;
        public override double atomicWeight { get; } = 31.01315d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Magnesium31() } },

        };
    }
}
    
    