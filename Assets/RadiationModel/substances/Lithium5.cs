using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium5 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium5";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 5.01254d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Helium4() } },

        };
    }
}
    
    