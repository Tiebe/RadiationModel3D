
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium147";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 146.94996d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Holmium147() } },

        };
    }
}
    
    