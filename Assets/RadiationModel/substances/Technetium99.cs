
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium99";
        public override double halfLife { get; } = 6661672567200.0d;
        public override double atomicWeight { get; } = 98.90625d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Ruthenium99() } },

        };
    }
}
    
    