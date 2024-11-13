
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium99m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium99m";
        public override double halfLife { get; } = 150.0d;
        public override double atomicWeight { get; } = 98.912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Molybdenum99() } },

        };
    }
}
    
    