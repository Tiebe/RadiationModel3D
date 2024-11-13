
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium183";
        public override double halfLife { get; } = 58.0d;
        public override double atomicWeight { get; } = 182.95736d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Hafnium183() } },

        };
    }
}
    
    