
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum107 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum107";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 106.92212d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Technetium107() } },

        };
    }
}
    
    