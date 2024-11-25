using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium218m : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium218m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 218.02011d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium214() }, { 1.0d, new AlphaParticle(10895002.09) } } },

        };
    }
}
    