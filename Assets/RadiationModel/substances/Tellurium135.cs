
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium135";
        public override double halfLife { get; } = 19.0d;
        public override double atomicWeight { get; } = 134.91655d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine135() } },

        };
    }
}
    
    