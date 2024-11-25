using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium169m";
        public override double halfLife { get; } = 160.0d;
        public override double atomicWeight { get; } = 168.93768d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lutetium169() }, { 1.06e-05d, new GammaParticle(29000.0, 0.04275) }, { 0.17856000000000002d, new GammaParticle(8810.0, 0.14073) } } },

        };
    }
}
    