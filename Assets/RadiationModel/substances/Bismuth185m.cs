using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth185m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth185m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 184.99769d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead184() }, { 1.0d, new ProtonParticle() } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium181() }, { 1.0d, new AlphaParticle(9240002.09) } } },

        };
    }
}
    