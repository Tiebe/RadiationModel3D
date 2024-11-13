
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium100m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium100m";
        public override double halfLife { get; } = 2.99d;
        public override double atomicWeight { get; } = 99.91468d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum100() } },

        };
    }
}
    
    