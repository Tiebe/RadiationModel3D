using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium37i : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium37i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 36.9788d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00025), new Potassium37() } },

        };
    }
}
    
    