
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium6 : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium6";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 6.01973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Helium4() } },

        };
    }
}
    
    