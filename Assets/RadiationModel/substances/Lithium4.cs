
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium4 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium4";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 4.02718d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Helium3() } },

        };
    }
}
    
    