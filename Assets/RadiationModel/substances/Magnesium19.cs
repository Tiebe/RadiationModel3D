
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium19 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium19";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 19.03418d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Neon17() } },

        };
    }
}
    
    