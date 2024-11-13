
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc78 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc78";
        public override double halfLife { get; } = 1.47d;
        public override double atomicWeight { get; } = 77.93829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gallium78() } },

        };
    }
}
    
    