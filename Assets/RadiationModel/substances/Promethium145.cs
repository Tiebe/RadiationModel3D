using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium145";
        public override double halfLife { get; } = 558558050.4d;
        public override double atomicWeight { get; } = 144.91276d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Neodymium145() } },
            { 2.8000000000000003e-09d, new List<RadioactiveSubstance> { new AlphaParticle(3342047.4), new Praseodymium141() } },

        };
    }
}
    
    