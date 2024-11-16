using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium133m";
        public override double halfLife { get; } = 18360.0d;
        public override double atomicWeight { get; } = 132.91156d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3113000.0), new Lanthanum133() } },

        };
    }
}
    
    