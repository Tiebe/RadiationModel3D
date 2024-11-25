using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium46m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46m";
        public override double halfLife { get; } = 0.00102d;
        public override double atomicWeight { get; } = 45.96106d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium46() }, { 1.0d, new GammaParticle(801100.0, 0.00155) }, { 5.26044414e-06d, new GammaParticle(536.0, 2.31314) }, { 6.439609000305949e-05d, new GammaParticle(4945.0, 0.25073) }, { 0.00012668914027751227d, new GammaParticle(4952.0, 0.25037) }, { 2.549076971942827e-05d, new GammaParticle(5444.0, 0.22774) }, { 2.549076971942827e-05d, new GammaParticle(5444.0, 0.22774) } } },

        };
    }
}
    