using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium96";
        public override double halfLife { get; } = 369792.0d;
        public override double atomicWeight { get; } = 95.90787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2972890.0), new Molybdenum96() } },

        };
    }
}
    
    