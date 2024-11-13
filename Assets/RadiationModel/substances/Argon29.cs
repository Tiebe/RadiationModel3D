
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon29 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon29";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 29.04076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sulfur27() } },

        };
    }
}
    
    