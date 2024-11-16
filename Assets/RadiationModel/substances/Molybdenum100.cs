using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum100 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum100";
        public override double halfLife { get; } = 2.2310765064e+26d;
        public override double atomicWeight { get; } = 99.90747d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-2, 3034400.0), new Ruthenium100() } },

        };
    }
}
    
    