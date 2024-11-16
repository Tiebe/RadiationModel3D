using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium96";
        public override double halfLife { get; } = 7.384326767999999e+26d;
        public override double atomicWeight { get; } = 95.90828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-2, 3356030.0), new Molybdenum96() } },

        };
    }
}
    
    