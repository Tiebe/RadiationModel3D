
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen11 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen11";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 11.02616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Carbon10() } },

        };
    }
}
    
    