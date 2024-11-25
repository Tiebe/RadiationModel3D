using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium216";
        public override double halfLife { get; } = 0.0045d;
        public override double atomicWeight { get; } = 216.02476d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium212() }, { 1.0d, new AlphaParticle(9552002.09) } } },

        };
    }
}
    