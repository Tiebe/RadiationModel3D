
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium103";
        public override double halfLife { get; } = 1.34d;
        public override double atomicWeight { get; } = 102.91945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum103() } },

        };
    }
}
    
    