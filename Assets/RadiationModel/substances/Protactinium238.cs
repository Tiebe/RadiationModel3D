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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium238() }, { 1.0d, new BetaParticle(-1, 1793150.00001) } } },

        };
    }
}
    