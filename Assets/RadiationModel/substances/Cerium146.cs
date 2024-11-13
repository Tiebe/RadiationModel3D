
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium146";
        public override double halfLife { get; } = 809.4d;
        public override double atomicWeight { get; } = 145.91881d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium146() } },

        };
    }
}
    
    