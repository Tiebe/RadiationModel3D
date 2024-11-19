using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium202m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium202m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 201.98493d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2600000.0, 0.00048)), new Iridium202() } },

        };
    }
}
    
    