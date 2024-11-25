using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium225 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium225";
        public override double halfLife { get; } = 1.7d;
        public override double atomicWeight { get; } = 225.02615d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium221() }, { 1.0d, new AlphaParticle(8427002.09) } } },

        };
    }
}
    