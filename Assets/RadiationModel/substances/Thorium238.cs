using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium238";
        public override double halfLife { get; } = 564.0d;
        public override double atomicWeight { get; } = 238.05639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1636000.0), new Protactinium238() } },

        };
    }
}
    
    