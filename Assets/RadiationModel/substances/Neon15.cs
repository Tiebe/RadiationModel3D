using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon15 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon15";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 15.04318d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Oxygen13() } },

        };
    }
}
    
    