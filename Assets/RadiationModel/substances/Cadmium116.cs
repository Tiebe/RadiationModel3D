using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium116";
        public override double halfLife { get; } = 8.488820088e+26d;
        public override double atomicWeight { get; } = 115.90476d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-2, 2813490.0), new Tin116() } },

        };
    }
}
    
    