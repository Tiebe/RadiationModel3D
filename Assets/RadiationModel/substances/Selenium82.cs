
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Selenium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium82";
        public override double halfLife { get; } = 2.7643889951999997e+27d;
        public override double atomicWeight { get; } = 81.9167d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Krypton82() } },

        };
    }
}
    
    