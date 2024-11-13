
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium238";
        public override double halfLife { get; } = 136.8d;
        public override double atomicWeight { get; } = 238.05464d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Uranium238() } },

        };
    }
}
    
    