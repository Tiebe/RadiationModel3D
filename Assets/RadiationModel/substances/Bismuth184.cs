using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth184 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth184";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 184.00134d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium180() }, { 1.0d, new AlphaParticle(9237002.09) } } },

        };
    }
}
    