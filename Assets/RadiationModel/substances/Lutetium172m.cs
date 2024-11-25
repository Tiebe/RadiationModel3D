using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172m";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 171.93914d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium172() }, { 3.9e-05d, new GammaParticle(41860.0, 0.02962) }, { 0.178932d, new GammaParticle(8810.0, 0.14073) } } },

        };
    }
}
    