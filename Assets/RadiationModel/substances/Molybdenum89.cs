
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum89 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum89";
        public override double halfLife { get; } = 126.6d;
        public override double atomicWeight { get; } = 88.91947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Niobium89() } },

        };
    }
}
    
    