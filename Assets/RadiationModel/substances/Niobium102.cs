
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium102 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium102";
        public override double halfLife { get; } = 4.3d;
        public override double atomicWeight { get; } = 101.91809d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum102() } },

        };
    }
}
    
    