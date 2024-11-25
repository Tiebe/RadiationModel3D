using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium156m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium156m";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 155.92969d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium156() }, { 0.00024d, new GammaParticle(52370.0, 0.02367) }, { 0.15244d, new GammaParticle(7656.0, 0.16194) } } },

        };
    }
}
    