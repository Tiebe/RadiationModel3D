
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Europium146";
        public override double halfLife { get; } = 398304.0d;
        public override double atomicWeight { get; } = 145.91721d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Samarium146() } },

        };
    }
}
    
    