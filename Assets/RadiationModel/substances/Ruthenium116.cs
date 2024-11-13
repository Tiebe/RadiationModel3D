
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium116";
        public override double halfLife { get; } = 0.204d;
        public override double atomicWeight { get; } = 115.93122d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Rhodium116() } },

        };
    }
}
    
    