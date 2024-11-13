
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium146n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium146n";
        public override double halfLife { get; } = 0.00118d;
        public override double atomicWeight { get; } = 145.92826d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Terbium146() } },

        };
    }
}
    
    