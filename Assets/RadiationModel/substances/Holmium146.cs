
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium146";
        public override double halfLife { get; } = 3.32d;
        public override double atomicWeight { get; } = 145.94499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium146() } },

        };
    }
}
    
    