using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine133p : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine133p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 132.91051d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0005, 2494000.0), new Iodine133() } },

        };
    }
}
    
    