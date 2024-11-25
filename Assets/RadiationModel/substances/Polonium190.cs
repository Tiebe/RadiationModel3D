using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium190 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium190";
        public override double halfLife { get; } = 0.00245d;
        public override double atomicWeight { get; } = 189.9951d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead186() }, { 1.0d, new AlphaParticle(8715002.09) } } },

        };
    }
}
    