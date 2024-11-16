using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium134m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.90768d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00042), new Barium134() } },

        };
    }
}
    
    