
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine29 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine29";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 29.01505d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Sulfur28() } },

        };
    }
}
    
    