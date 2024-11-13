
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum85 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum85";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 84.93826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium85() } },

        };
    }
}
    
    