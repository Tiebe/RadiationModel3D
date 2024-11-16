using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon16 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon16";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 16.02575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Oxygen14() } },

        };
    }
}
    
    