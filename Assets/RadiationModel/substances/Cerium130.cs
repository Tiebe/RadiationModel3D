
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium130";
        public override double halfLife { get; } = 1374.0d;
        public override double atomicWeight { get; } = 129.91474d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum130() } },

        };
    }
}
    
    