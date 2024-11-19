using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine209m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine209m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 208.98878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00051, 2429000.0), new Astatine209() } },

        };
    }
}
    
    