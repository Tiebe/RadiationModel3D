
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium133";
        public override double halfLife { get; } = 5820.0d;
        public override double atomicWeight { get; } = 132.91152d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum133() } },

        };
    }
}
    
    