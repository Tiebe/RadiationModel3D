using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium134m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.91237d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00039), new Cerium134() } },

        };
    }
}
    
    