
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium135";
        public override double halfLife { get; } = 744.0d;
        public override double atomicWeight { get; } = 134.91818d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium135() } },

        };
    }
}
    
    