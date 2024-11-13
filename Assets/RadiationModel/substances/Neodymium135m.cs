
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium135m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium135m";
        public override double halfLife { get; } = 330.0d;
        public override double atomicWeight { get; } = 134.91825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium135() } },

        };
    }
}
    
    