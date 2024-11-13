
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium99";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 98.91161d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum99() } },

        };
    }
}
    
    