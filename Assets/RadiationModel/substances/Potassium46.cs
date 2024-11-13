
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium46";
        public override double halfLife { get; } = 96.3d;
        public override double atomicWeight { get; } = 45.96198d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium46() } },

        };
    }
}
    
    