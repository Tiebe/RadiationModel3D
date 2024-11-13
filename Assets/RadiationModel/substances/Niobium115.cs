
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium115";
        public override double halfLife { get; } = 0.023d;
        public override double atomicWeight { get; } = 114.96685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum115() } },

        };
    }
}
    
    