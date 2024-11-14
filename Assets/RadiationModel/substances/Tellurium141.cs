using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium141";
        public override double halfLife { get; } = 0.193d;
        public override double atomicWeight { get; } = 140.9456d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9257000.0), new Iodine141() } },

        };
    }
}
    
    