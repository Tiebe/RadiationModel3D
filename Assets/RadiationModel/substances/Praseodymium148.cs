using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium148";
        public override double halfLife { get; } = 137.4d;
        public override double atomicWeight { get; } = 147.92213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4873100.0), new Neodymium148() } },

        };
    }
}
    
    