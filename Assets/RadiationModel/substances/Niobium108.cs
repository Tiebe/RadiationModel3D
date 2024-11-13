
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium108 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium108";
        public override double halfLife { get; } = 0.201d;
        public override double atomicWeight { get; } = 107.93608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum108() } },

        };
    }
}
    
    