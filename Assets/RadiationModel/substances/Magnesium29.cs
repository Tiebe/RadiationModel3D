
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium29 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium29";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 28.98861d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum29() } },

        };
    }
}
    
    