using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron7 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron7";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 7.02971d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Beryllium6() } },

        };
    }
}
    
    