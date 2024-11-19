using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium217m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium217m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 217.0115d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9549d, new List<RadioactiveSubstance> { new GammaParticle(0.00062, 2013000.0), new Actinium217() } },
            { 0.0451d, new List<RadioactiveSubstance> { new AlphaParticle(12864047.4), new Francium213() } },

        };
    }
}
    
    